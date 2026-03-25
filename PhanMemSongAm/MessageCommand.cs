using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemSongAm
{
    // $iam: "Phuc" $message: "Viet tinh tien di" $with: "Dat" $topic: "Viet tinh tien di"
    // $iam: "Phuc" $message: "Viet ve nha di Viet" $with: "Dat" $topic: "Viet ve nha di Viet"
    public class MessageCommand
    {
        private string _command = "";

        private string _iam = "";
        private string _message  = "";
        private string _with = "";
        private string _topic = "";

        private Dictionary<string, string> _parameters = new Dictionary<string, string>();

        public MessageCommand(string command)
        {
            this._command = command;
            this.toParameters(command);

            this._iam = this.Iam();
            this._message = this.Message();
            this._with = this.With();
            this._topic = this.Topic();
        }

        //public MessageCommand(string message)
        //{

        //}

        public void Print()
        {
            Console.WriteLine($"iam: {this._iam}");
            Console.WriteLine($"message: {this._message}");
            Console.WriteLine($"with: {this._with}");
            Console.WriteLine($"topic: {this._topic}");
        }

        private void toParameters(string command)
        {
            if (command != null && command.Contains('$'))
            {
                var parameters = command.Split('$');

                for (int i = 0; i < parameters.Length; i++)
                {
                    if (parameters[i] != null && parameters[i].Contains(':'))
                    {
                        var paramPair = parameters[i].Split(':');

                        this._parameters.Add(paramPair[0], paramPair[1]);
                    }
                }
            }
        }

        private string Iam()
        {
            string iam = "";

            if (this._parameters.ContainsKey("iam") && this._parameters["iam"] != null)
            {
                iam = this._parameters["iam"];
            }

            return iam;
        }

        private string Message()
        {
            string message = "";

            if (this._parameters.ContainsKey("message") && this._parameters["message"] != null)
            {
                message = this._parameters["message"];
            }

            return message;
        }

        private string With()
        {
            string with = "";

            if (this._parameters.ContainsKey("with") && this._parameters["with"] != null)
            {
                with = this._parameters["with"];
            }

            return with;
        }

        private string Topic()
        {
            string topic = "";

            if (this._parameters.ContainsKey("topic") && this._parameters["topic"] != null)
            {
                topic = this._parameters["topic"];
            } else if (this._parameters["message"] != null)
            {
                topic = this._parameters["message"];
            }

            return topic;
        }
    }
}
