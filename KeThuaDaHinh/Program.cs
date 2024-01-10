using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThuaDaHinh
{

    //class DongVat {

    //    protected string ten;
    //    public virtual void keu() {
    //        Console.WriteLine("Chua biet keu nhu the nao");
    //    }
    //}

    class Meo  {
        private string ten;
        public Meo() { }
        public Meo(string ten) {
            this.ten = ten;
        }
        public void keu() {
            Console.WriteLine("Meo meo....");
        }
    }
    class Cho 
    {
        private string ten;
        public Cho() { }
        public Cho(string ten)
        {
            this.ten = ten;
        }
        public void keu()
        {
            Console.WriteLine("Gau Gau....");
        }
    }
    class Ga
    {
        private string ten;
        public Ga() { }
        public Ga(string ten)
        {
            this.ten = ten;
        }
        public void keu()
        {
            Console.WriteLine("Chip chip....");
        }
    }

    class QuanLyVatNuoi
    {

        private Meo[] dsMeo;
        private int soluongmeo;
        private Cho[] dsCho;
        private int soluongcho;
        private Ga[] dsGa;
        private int soluongga;

        public QuanLyVatNuoi()
        {
            dsMeo = new Meo[5];
            dsCho = new Cho[15];
            dsGa = new Ga[10];
        }

        public void ThemGa(Ga ga) {
            // cai dat lenh them ga vao mang dsGa
            if (soluongga >= dsGa.Length)
            {
                Console.WriteLine("Het chuong nuoi ga");
            }
            else
            {
                dsGa[soluongga++] = ga;
            }
        }
        public void ThemCho(Cho cho)
        {
            //cai dat lenh them cho vao mang dsCho
            if (soluongcho >= dsCho.Length)
            {
                Console.WriteLine("Het chuong nuoi cho");
            }
            else
            {
                dsCho[soluongcho++] = cho;
            }
        }
        public void ThemMeo(Meo meo)
        {
            //cai dat lenh them meo vao mang dsMeo
            if (soluongmeo >= dsMeo.Length)
            {
                Console.WriteLine("Het chuong nuoi meo");
            }
            else
            {
                dsMeo[soluongmeo++] = meo;
            }
        }

        public void Xuat()
        {
            //chó keu
            for (int i = 0; i < soluongcho; i++)
            {
                dsCho[i].keu();
            }
            //gà keu
            for (int i = 0; i < soluongga; i++)
            {
                dsGa[i].keu();
            }
            //mèo kêu
            for (int i = 0; i < soluongmeo; i++)
            {
                dsMeo[i].keu();
            }
        }       

    }

    class Program
    {
        static void Main(string[] args)
        {
            QuanLyVatNuoi ql = new QuanLyVatNuoi();
            ql.ThemCho(new Cho("Lucky"));
            ql.ThemCho(new Cho("Bach bao"));

            ql.ThemGa(new Ga("Ga 1"));
            ql.ThemGa(new Ga("Ga 2"));
            ql.ThemGa(new Ga("Ga 3"));

            ql.ThemMeo(new Meo("Meo 1"));
            ql.ThemMeo(new Meo("Meo 2"));
            ql.ThemMeo(new Meo("Meo 3"));
            ql.ThemMeo(new Meo("Meo 4"));
          

            ql.Xuat();

            Console.ReadLine();
        }
    }
}
