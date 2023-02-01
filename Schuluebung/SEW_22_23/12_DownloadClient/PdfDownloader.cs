using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _12__DownloadClient
{
    internal class PdfDownloader
    {
        public async Task<string> DownloadAsync(Uri url)
        {
            using (WebClient client = new WebClient()) 
            {
                string pdfName;
                // http://asdf.at/downloads/document.pdf
                if (!url.Segments.Last().EndsWith(".pdf")){
                    pdfName = url.Segments.Last() + ".pdf";      // Segments: einzelne "Teile" der URL durch / getrennt

                }
                else
                {
                    pdfName = url.Segments.Last();
                }
                string fileName = @"C:\dev\" + pdfName;
                Console.WriteLine("Begin Download: " + pdfName);
                Task t = client.DownloadFileTaskAsync(url, fileName);
                await t;
                Console.WriteLine("Download finished: " +pdfName);
                // hier wird automatisch ein Task Objekt zurückgegeben (macht Compiler)
                return fileName;    // besser ein event nutzen und darauf warten, wenn man eine aktive Medlung bekommen möchte
            }
        }
    }
}
