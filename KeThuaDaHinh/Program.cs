using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThuaDaHinh
{

    class DongVat {
        private string ten;
        public DongVat() { }
        public DongVat(string ten) {
            this.ten = ten;
        }
        public virtual void keu() {
            Console.WriteLine("Chua biet keu the nao.");
        }      
    }        

    class Meo: DongVat  {        
        public Meo() { }
        public Meo(string ten) : base(ten) {            
        }
        public override void keu() {
            Console.WriteLine("Meo meo....");
        }      

    }
    class Cho : DongVat
    {
        public Cho() { }
        public Cho(string ten):base(ten)
        {          
        }
        public override void keu()
        {
            Console.WriteLine("Gau Gau....");
        }        
    }
    class Ga: DongVat
    {        
        public Ga() { }
        public Ga(string ten):base(ten)
        {          
        }
        public override void keu()
        {
            Console.WriteLine("Chip chip....");
        }       
    }

    class QuanLyVatNuoi
    {

        private DongVat[] dsvatnuoi;
        private int soluong;

        public QuanLyVatNuoi()
        {
            dsvatnuoi = new DongVat[30];
        }

        public void Them(DongVat dv) {
            // cai dat lenh them ga vao mang dsGa
            if (soluong >= dsvatnuoi.Length)
            {
                Console.WriteLine("Het chuong nuoi");
            }
            else
            {
                dsvatnuoi[soluong++] = dv;
            }
        }
        
        public void Xuat()
        {
            //chó keu, mèo kêu ,gà kêu            
            Console.WriteLine("***Vat nuoi keu:");
            for (int i = 0; i < soluong; i++)
            {
                dsvatnuoi[i].keu();
            }           
        }       

    }

    class Program
    {
        static void Main(string[] args)
        {
            QuanLyVatNuoi ql = new QuanLyVatNuoi();
            ql.Them(new Cho("Lucky"));
            ql.Them(new Cho("Bach bao"));
           

            ql.Them(new Ga("Ga 1"));
            ql.Them(new Ga("Ga 2"));
            ql.Them(new Ga("Ga 3"));

            ql.Them(new Meo("Meo 1"));
            ql.Them(new Meo("Meo 2"));
            ql.Them(new Meo("Meo 3"));
            ql.Them(new Meo("Meo 4"));
                  


            ql.Xuat();
            Console.ReadLine();
        }
    }
}
