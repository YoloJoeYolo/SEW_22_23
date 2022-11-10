#include <SPI.h>
#include <Ethernet.h>
#include <String.h>
#include <dht_nonblocking.h>
#define DHT_SENSOR_TYPE DHT_TYPE_11

byte mac[] = { 0x12,0x34,0x56, 0x78, 0x90, 0x22};
static const int DHT_SENSOR_PIN = 2;
static const int port = 8888;
DHT_nonblocking dht_sensor( DHT_SENSOR_PIN, DHT_SENSOR_TYPE );
EthernetServer server(port);  // 8888 --> Port

/*
 * Poll for a measurement, keeping the state machine alive.  Returns
 * true if a measurement is available.
 */
static bool measure_environment( float *temperature, float *humidity )
{
  static unsigned long measurement_timestamp = millis( );

  /* Measure once every four seconds. */
  if( millis( ) - measurement_timestamp > 3000ul )
  {
    if( dht_sensor.measure( temperature, humidity ) == true )
    {
      measurement_timestamp = millis( );
      return( true );
    }
  }

  return( false );
}

void setup() {
  // Get IP
  Ethernet.init(10);
  Ethernet.begin(mac);  // IP. Gateway, Subnet, DNS vom DHCP
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

  server.begin(); // Server horcht auf eingehende Verbindungen
}

void loop() {
  float temperature;
  float humidity;

  /* Measure temperature and humidity.  If the functions returns
     true, then a measurement is available. */
  if( measure_environment( &temperature, &humidity ) == true )
  {
    Serial.print( temperature, 1 );
    Serial.print( " deg. C\n" );
    server.print(temperature);
  }
}
