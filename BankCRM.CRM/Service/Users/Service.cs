using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BankCRM.CRM.Data.Configurations;
using BankCRM.CRM.Domain.Entities;

namespace BankCRM.CRM.Service.Users;

internal class Service
{
    public Service()
    {
        while (true)
        {
            Console.Write("Komanda raqamini kiriting: ");
            string? num = Console.ReadLine();
            switch (num)
            {
                case "1":
                    Create();
                    break;
                case "2":
                    Update();
                    break;
                case "3":
                    Get();
                    break;
                case "4":
                    GetAll();
                    break;
                case "5":
                    Delete();
                    break;

            }
        }
    }

    private void Create()
    {
        User user = new User();
        string content = $"ID={user.Id},Name={user.Name},Surname={user.Surname},Age={user.Age},Disease={user.Disease},CreatedTime={user.CreationTime}\n";
        File.AppendAllText(Config.Path, content);
    }
    private void Update()
    {

        Console.Write("Mijozni id sini kiriting: ");
        int ClientId = Convert.ToInt32(Console.ReadLine());
        int bol = Find(ClientId);
        if (bol == 0)
        {
            Console.WriteLine("Bunday mijoz mavjud emas");
        }
        else
        {
            Console.Write("Mijozni yangi id sini kiriting:");
            int? newId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mijozni yangi nomini kiriting:");
            string? newName = Console.ReadLine();
            Console.Write("Mijozni yangi familiyasini kiriting:");
            string? newSurname = Console.ReadLine();
            Console.Write("Mijozni yangi yoshini kiriting:");
            int? newAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mijozni yangi kasalini kiriting:");
            string? newDisease = Console.ReadLine();
            List<string> urur = new List<string>();
            string[] line = File.ReadAllLines(Config.Path);
            foreach(string line2 in line)
            {
                urur.Add(line2);
            }
            urur.RemoveAt(bol);
            urur.Add($"ID={newId},Name={newName},Surname={newSurname},Age={newAge},Disease={newDisease},CreatedTime={DateTime.Now}");
            File.WriteAllLines(Config.Path,urur);

        }
    }
    private void Delete()
        {
            Console.WriteLine("hi");
        }
        private void Get()
        {
        Console.Write("Mijozni id sini kiriting:");
        int mijozId = Convert.ToInt32(Console.ReadLine());
        int a = Find(mijozId);
        if(a == 0)
        {
            Console.WriteLine("Bunday mijoz mavjud emas");
        }
        else
        {
            string[] line = File.ReadAllLines(Config.Path);
            string dat = line[a];
            Console.WriteLine(dat);
        }
        }
        private void GetAll()
        {
        string[] line = File.ReadAllLines(Config.Path);
        foreach (string i in line)
        {
            Console.WriteLine(i);
        }
    }
        private int Find(int id)
        {
            int n = 0;
            string[] lines = File.ReadAllLines(Config.Path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] lin = lines[i].Split(",");
                string[] li = lin[0].Split("=");
                if (Convert.ToInt32(li[1]) == id)
                {
                    Console.WriteLine("Mijoz topildi");
                    n = i;
                    break;
                }
            }
            return n;

        }
    }

