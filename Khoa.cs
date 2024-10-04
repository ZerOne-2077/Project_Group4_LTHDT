using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _THLTHDT_B3
{
    class Khoa
    {
        List<GiangVien> lstGV;

        public List<GiangVien> LstGV
        {
            get { return lstGV; }
            set { lstGV = value; }
        }
        private string TenKhoa;

        public string TenKhoa1
        {
          get { return TenKhoa; }
          set { TenKhoa = value; }
        }
        private string ViTri;

        public string ViTri1
        {
          get { return ViTri; }
          set { ViTri = value; }
        }
        private int SDT;

        public int SDT1
        {
          get { return SDT; }
          set { SDT = value; }
        }
        private int SoNganh;

        public int SoNganh1
        {
          get { return SoNganh; }
          set { SoNganh = value; }
        }
        public Khoa()
        {
            LstGV = new List<GiangVien>();

        }
        public void NhapDSGV(){
            Console.WriteLine("Nhap ten khoa: ");
            TenKhoa = Console.ReadLine();
            Console.WriteLine("Nhap vi tri: ");
            ViTri = Console.ReadLine();
            Console.WriteLine("Nhap so dien thoai:");
            SDT = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nganh");
            SoNganh = int.Parse(Console.ReadLine());    
            Console.WriteLine("Nhap so luong giang vien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap thong tin giang vien thu {0}", i + 1);
                GiangVien gv = new GiangVien();
                gv.nhap();
                LstGV.Add(gv);
            }
        }

        public void DocFileDSGV(string f)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(f);
            TenKhoa = xmlDoc.SelectSingleNode("Khoa/TenKhoa").InnerText;
            ViTri = xmlDoc.SelectSingleNode("Khoa/ViTri").InnerText;
            SDT = int.Parse(xmlDoc.SelectSingleNode("Khoa/SDT").InnerText);
            SoNganh = int.Parse(xmlDoc.SelectSingleNode("Khoa/SoNganh").InnerText);
            XmlNodeList nodeLST = xmlDoc.SelectNodes("/Khoa/DSGV/GV");
            foreach (XmlNode node in nodeLST)
            {
                GiangVien gv = new GiangVien();
                gv.HoTen = node["hoTen"].InnerText;
                gv.SoNhomHD = int.Parse(node["soNhomHD"].InnerText);

                LstGV.Add(gv);
            }
        }
        public void XuatDSGV(){
            Console.WriteLine("Ten khoa: {0}", TenKhoa);
            Console.WriteLine("Vi tri: {0}", ViTri);
            Console.WriteLine("So dien thoai: {0}", SDT);
            Console.WriteLine("So nganh: {0}", SoNganh);
            Console.WriteLine("\n-----------Danh sach giang vien--------- ");
            foreach (GiangVien gv in LstGV){
                Console.WriteLine("Thong tin giang vien thu {0} la: ", LstGV.IndexOf(gv));
                gv.xuat();
            }
        }
        public List<GiangVien> SapXep()
        {
            List<GiangVien> lstSXSNT = new List<GiangVien>();   
            lstSXSNT = lstGV.OrderBy(t => t.SoNhomHD).ToList(); 
            return lstSXSNT;
        }
    }
}
