using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        ProcessStartInfo z = new ProcessStartInfo();
        z.FileName = "zenity.exe";
        z.Arguments = "--forms --title= \"Add a Link\" --text=\"Forms Dialog\" --add-entry=\"Link\" --add-entry=\"Info\" --add-entry=\"URL\"";
        z.WorkingDirectory = @"C:\Program Files (x86)\Zenity\bin\";
        z.RedirectStandardOutput = true;
        z.RedirectStandardError = true;
        z.UseShellExecute = false;


        using (Process process = Process.Start(z))
        {
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            // Skriv ut formuläret på konsolen
            Console.WriteLine(output);

            // Läs indata från användaren från konsolen
            string link = Console.ReadLine();
            string info = Console.ReadLine();
            string url = Console.ReadLine();

            // Skriv ut den inmatade datan på konsolen
            Console.WriteLine($"Link: {link}");
            Console.WriteLine($"Info: {info}");
            Console.WriteLine($"URL: {url}");
        }


    }
}
