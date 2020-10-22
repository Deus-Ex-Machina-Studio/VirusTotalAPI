using System;
using System.Threading.Tasks;

class Program {

    static void Main(string[] args) {
        VirusTotal.API.APIKEY = "<ВАШ APIKEY>";

        for (int i = 0; i < 25; i++) {
            VirusTotal.API.ScanFile("E:/PIL20.py");
            VirusTotal.API.ReportFile();
            Console.WriteLine($"SCANS: {VirusTotal.API.scans.Count}, LAST_SCAN: {VirusTotal.API.scans[0].date}");
            System.Threading.Thread.Sleep(20000);
        }

        Console.ReadLine();
    }
}

