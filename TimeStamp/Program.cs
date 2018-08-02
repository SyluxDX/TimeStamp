using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TimeStamp{
    class Program{
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern int FreeConsole();
        [STAThread]
        static void Main(string[] args){
#if DEBUG
            //args = new[] { "logtime", "02-03-2017" };
#endif
            if (args.Length >= 1){
                switch (args[0]){
                    case "logtime":
                        string log=LogTime();
                        //print log to console
                        Log(log, 1000);
                        break;
                    case "computetime":
                        string[] output;
                        output=ComputeTimeLogs(args);
                        if (output[0] == "error"){
                            Console.WriteLine(output[1]);
                            Console.WriteLine("Press Enter to exit");
                            Console.ReadLine();
                        }else{
                            Log(output[1], 1500);
                        }
                        break;
                    default:
                        Log("Wrong Command line Argument", 1500);
                        break;

                }
            }else{
                // start GUI
                //Log("Command line Argument missing", 1500);
                FreeConsole();
                Application.Run(new GUI());
            }
        }

        public static string LogTime(){
            string path = CheckDirectory(Directory.GetCurrentDirectory(), "timestamp");
            StreamWriter file = GetFileWriter(path);

            //get timestamp and write to file
            DateTime date = DateTime.Now;
            file.WriteLine(date.ToString("HH:mm:ss"));
            file.Close();

            string logLine = "TimeStamped at:" + Environment.NewLine + "  " + date.ToString("HH:mm:ss");
            return logLine;
        }

        public static string[] ComputeTimeLogs(string[] args){
            string[] log = new string[2];
            string path = CheckDirectory(Directory.GetCurrentDirectory(), "timestamp");
            string fileName;
            if (args.Length == 2){
                fileName = args[1].Split('.')[0] + ".txt";
            }else{
                fileName = GetFileName(path);
            }
            try{
                Console.WriteLine("file: {0}",fileName);
                Console.WriteLine("path: {0}",path);
                string[] lines = File.ReadAllLines(Path.Combine(path, fileName));
                string output = ComputeTime(lines);
                if (output == ""){
                    log[0] = "error";
                    log[1] = "  Numer of TimeStamps aren't par." + Environment.NewLine +
                        "  Run Timestamp to close the time computation.";
                    return log;
                }

                //Write to file;
                path = CheckDirectory(path, "computed");
                fileName = Path.Combine(path, fileName);
                File.WriteAllText(fileName, output);

                //print log to console
                log[0] = "";
                log[1]= output;
                return log;

            }catch (FileNotFoundException e){
                log[0] = "error";
                log[1] = e.Message;
                return log;
            }
        }

        private static string CheckDirectory(string path, string folderName){
            //Check for existing folder
            string folder = Path.Combine(path, folderName);
            if (!Directory.Exists(folder)){
                Directory.CreateDirectory(folder);
            }
            return folder;
        }

        private static string GetFileName(string path){
            DateTime date = DateTime.Now;
            string dateString = date.ToString("yyyy-MM-dd");
            string fileName = dateString + ".txt";
            return fileName;
        }

        private static StreamWriter GetFileWriter(string path){
            string fileName = GetFileName(path);
            StreamWriter file = new StreamWriter(Path.Combine(path, fileName), true);
            return file;
        }

        private static void Log(string log, int timer){
            Console.WriteLine(log);
            System.Threading.Thread.Sleep(timer);
        }

        private static string ComputeTime(string[] lines){
            int len = lines.Length;
            TimeSpan total = new TimeSpan();
            TimeSpan subTotal;
            DateTime date1;
            DateTime date2;
            string output = "";
            if ((len % 2) == 0){
                output += "Subtotal" + Environment.NewLine;
                for (int i = 0; i < len; i += 2){
                    date1 = DateTime.Parse(lines[i]);
                    date2 = DateTime.Parse(lines[i + 1]);
                    subTotal = date2.Subtract(date1);
                    output += "  " + subTotal.ToString() + Environment.NewLine;
                    total += subTotal;
                }

                output += "Total:" + Environment.NewLine;
                output += "  " + total.ToString();
            }
            return output;
        }

        public static string CheckTime(){
            string output;
            string[] logs;

            string path = CheckDirectory(Directory.GetCurrentDirectory(), "timestamp");
            string fileName = GetFileName(path);
            string[] lines = File.ReadAllLines(Path.Combine(path, fileName));
            int len = lines.Length;
            if ((len % 2) == 0){
                logs = lines;
            }else{
                logs = new string[len + 1];
                for (int i = 0; i < len; i++){
                    logs[i] = lines[i];
                }
                DateTime date = DateTime.Now;
                logs[len] = date.ToString("HH:mm:ss");
            }
            output = ComputeTime(logs);
            return output;
        }
    }
}
