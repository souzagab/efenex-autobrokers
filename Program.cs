using Dapper;
using Efenex.controller;
using Efenex.model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Efenex
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());


            var clientes = new ClientesController();



            var cliente = new Cliente { Nome = "Atualiza porra", DataNascimento="22/10/2020",  Cpf="1231231231", Rg="12312312"};

            Console.WriteLine(clientes.Update(1, cliente));
           

        }
    }
}
