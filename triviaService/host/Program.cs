﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host {
    class Program {
        static void Main(string[] args)
        {
            ServiceHost service = new ServiceHost(typeof(triviaService.TriviaService));
            service.Open();
            Console.ReadLine();
        }
    }
}
