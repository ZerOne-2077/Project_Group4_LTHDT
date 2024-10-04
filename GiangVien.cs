using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _THLTHDT_B3
{
    class GiangVien
    {
        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private int soNhomHD;

        public int SoNhomHD
        {
            get { return soNhomHD; }
            set { soNhomHD = value; }
        }

        public GiangVien() { }
        public GiangVien(string hoTen, int soNhomHD)
        {
            this.hoTen = hoTen;
            this.soNhomHD = soNhomHD;
        }


        public void nhap(){

            Console.WriteLine("Nhap ho ten giang vien: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("\nNhap so nhom huong dan: ");
            soNhomHD = Int32.Parse(Console.ReadLine());
        }
        public void xuat(){
            Console.WriteLine("Ho ten giang vien: {0}", hoTen);
            Console.WriteLine("Nhom huong dan: {0}\n", soNhomHD);
        }
    }
}
