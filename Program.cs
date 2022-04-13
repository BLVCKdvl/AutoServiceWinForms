using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoServicewinForms.model;
using System.IO;


namespace AutoServicewinForms
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Note note = new Note("Дмитрий Маканов", "Chevrole Corvette ZR1", "11.04.2022", new WorkCollection(
                new List<WorkType> {
                new WorkType("Чистка машины", 1.0m),
                new WorkType("установка турбонаддува", 2.0m),
                new WorkType("Замена масла", 3.0m),
                }) );

            Form1 form = new Form1();
            form.msg = note.ToString() + $"\nGeneral cost:{CostCalculator.CalculateCost(note.workCollection)}";
            File.WriteAllText("out.txt", form.msg);
            Application.Run(form);
        }
    }
}
