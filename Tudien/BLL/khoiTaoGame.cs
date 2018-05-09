using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tudien.DTO;

namespace Tudien.BLL
{
    public class khoiTaoGame
    {
        public DictionaryData[] co20PhanTu;
        public int[] chiSo = { 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19};
        public static int soDem;
        public string dung = "";
        public int diem;
        public khoiTaoGame()
        {
            DictionaryManager dicMana = new DictionaryManager();
            co20PhanTu = dicMana.Items.Item.ToArray();
            int dd = 0;
            for(int i = dicMana.Items.Item.Count-1; i>= dicMana.Items.Item.Count - 21; i--)
            {
                co20PhanTu[dd] = dicMana.Items.Item[i];
                dd++;
            }
            dd = 0;
            soDem = 0;
            diem = 0;
        }
        public void HienThi(TextBox cauHoi, Button dapan1, Button dapan2, Button dapan3, Button dapan4)
        {
            Random rand = new Random();
            cauHoi.Text = co20PhanTu[soDem].Key;

            int[] arr4phantu = { 0,1,2,3};
            arr4phantu[0] = rand.Next(4);
            switch (arr4phantu[0])
            {
                    case 0:
                        dapan1.Text = co20PhanTu[chiSo[soDem]].Meaning;
                        dapan2.Text = co20PhanTu[chiSo[(soDem + rand.Next(0,20))%20]].Meaning;
                        dapan3.Text = co20PhanTu[chiSo[(soDem + rand.Next(0, 20)) % 20]].Meaning;
                        dapan4.Text = co20PhanTu[chiSo[(soDem + rand.Next(0, 20)) % 20]].Meaning;
                        break;
                    case 1:
                        dapan2.Text = co20PhanTu[chiSo[soDem]].Meaning;
                        dapan1.Text = co20PhanTu[chiSo[(soDem + rand.Next(0, 20)) % 20]].Meaning;
                        dapan3.Text = co20PhanTu[chiSo[(soDem + rand.Next(0, 20)) % 20]].Meaning;
                        dapan4.Text = co20PhanTu[chiSo[(soDem + rand.Next(0, 20)) % 20]].Meaning;
                        break;
                    case 2:
                        dapan3.Text = co20PhanTu[chiSo[soDem]].Meaning;
                        dapan1.Text = co20PhanTu[chiSo[(soDem + rand.Next(0, 20)) % 20]].Meaning;
                        dapan2.Text = co20PhanTu[chiSo[(soDem + rand.Next(0, 20)) % 20]].Meaning;
                        dapan4.Text = co20PhanTu[chiSo[(soDem + rand.Next(0, 20)) % 20]].Meaning;
                        break;
                    default:
                        dapan4.Text = co20PhanTu[chiSo[soDem]].Meaning;
                        dapan1.Text = co20PhanTu[chiSo[(soDem + rand.Next(0, 20)) % 20]].Meaning;
                        dapan2.Text = co20PhanTu[chiSo[(soDem + rand.Next(0, 20)) % 20]].Meaning;
                        dapan3.Text = co20PhanTu[chiSo[(soDem + rand.Next(0, 20)) % 20]].Meaning;
                        break;
            }
            dung = co20PhanTu[chiSo[soDem]].Meaning;
            //cauHoi.Text = dung;
            cauHoi.Text = co20PhanTu[chiSo[soDem]].Key;
            soDem++;
            if (soDem == 19)
            {
                doiViTri();
                soDem = 0;
            }
        }
        public void doiViTri()
        {
            Random rand = new Random();
            for(int i = 0;i < 15;i++)
            {
                int so = rand.Next(0, 20);
                int asd=  chiSo[so];
                chiSo[so] = chiSo[(20 - so) % 20];
                chiSo[(20 - so) % 20] = asd;
            }
            
        }
    }
}
