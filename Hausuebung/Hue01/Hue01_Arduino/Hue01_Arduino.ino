#include <SPI.h>
#include <Ethernet.h>
#include <EthernetUdp.h>
#include <String.h>
#include "DHT.h"

#define DHTPIN 2
#define DHTTYPE DHT11

static byte mac[] = { 0x12,0x34,0x56, 0x78, 0x90, 0x22};
static const int port = 8888;
static IPAddress ip(255, 255, 255, 255);


DHT dht(DHTPIN, DHTTYPE);
EthernetUDP udp;

void setup() {
  Ethernet.init(10);
  Ethernet.begin(mac);  // IP. Gateway, Subnet, DNS vom DHCP
  udp.begin(port);  
  Serial.begin(9600);
  while(!Serial){
    // warten bis der serielle Kommunikationspartner verfügbar
  }

  // Fehlerbehandlung
  if(Ethernet.hardwareStatus() == EthernetNoHardware){
    Serial.println("Kein Ethernet Shield vorhanden");
    while (true){
      delay(100); // ohne Ethernet Shield, machen wir nichts
    }
  }
  if(Ethernet.linkStatus() == LinkOFF){
    Serial.println("Kein Ethernet Kabel verbunden");
  }
  
  Serial.print("IP: ");
  Serial.println(Ethernet.localIP());
  Serial.print("Sending port: ");
  Serial.println(port);   
}

void loop() {
  float temperature = dht.readTemperature();
  if (!isnan(temperature)) {
    String message = "-temperature measurement system werner-" + String(temperature , 2) + "###";

    Serial.println(message);
    
    udp.beginPacket( ip, port);
    udp.print(message);
    udp.endPacket();
  }
  delay(3000);
}
