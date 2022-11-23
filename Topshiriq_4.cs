using System;
namespace C_
{
    class Tikuvchilik_sehi
    {
        public string nomi { get; set; }
        public string boshliq { set; get; }
        public int ishchi_soni { set; get; }
        public string zavod { set; get; }

        public Tikuvchilik_sehi() : this("Yuksalish", "Baxtiyor Aka")
        { }
        public Tikuvchilik_sehi(string nomi, string boshliq) : this(nomi, boshliq, 20, "Trikotaj")
        { }
        public Tikuvchilik_sehi(string nomi, string boshliq, int ishchi_soni, string zavod)
        {
            this.nomi = nomi;
            this.boshliq = boshliq;
            this.ishchi_soni = ishchi_soni;
            this.zavod = zavod;
        }
         void ShowInfo()
        {
            Console.WriteLine($"Zavod nomi:{nomi} \n Boshlig'i:{boshliq} \n Ishchilar soni:{ishchi_soni} \n Zavod :{zavod}");
            Console.WriteLine("*******************");
        }
        public void CheckIshchi_soni()
        {
            if (ishchi_soni > 20)
                ShowInfo();
        }



    }


    class Tikuvchilar
    {
        Tikuvchilik_sehi[] data;//massiv
        public Tikuvchilar(int n) //konstruktor
        {
            data = new Tikuvchilik_sehi[n];//massivga murojat
        }
        public Tikuvchilik_sehi this[int id] //indeksator
        {
            set
            {
                data[id] = value;
            }
            get
            {
                return data[id];
            }
        }
    }
    
}