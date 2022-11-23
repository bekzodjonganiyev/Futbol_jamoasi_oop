// using System;
// namespace C_

// {
//     class TIkuvchilik_Sexi
//     {
//         string nomi;
//         string boshliq;
//         int ishchi_soni;
//         string zavod;
//         public TIkuvchilik_Sexi() : this("Bobur tekstile", "Bobur Hamidov")
//         { }
//         public TIkuvchilik_Sexi(string nomi, string boshliq) : this(nomi, boshliq, 20, "Tikuvchilik sexi")
//         { }
//         public TIkuvchilik_Sexi(string nomi, string boshliq, int ishchi_soni, string zavod)
//         {
//             this.nomi = nomi;
//             this.boshliq = boshliq;
//             this.ishchi_soni = ishchi_soni;
//             Zavod_nomi = zavod;
//         }
//         // public string Ism
//         // {
//         //     set
//         //     {
//         //         nomi = value;
//         //     }
//         //     get
//         //     {
//         //         return nomi;
//         //     }
//         // }
//         public string Zavod_nomi
//         {
//             set
//             {
//                 nomi = value;
//             }
//             get
//             {
//                 return nomi;
//             }
//         }
//         private void ShowInfo()
//         {
//             Console.WriteLine($"Zavod nomi:{nomi} \n Boshlig'i:{boshliq} \n Ishchilar soni:{ishchi_soni} \n Zavod :{zavod}");
//         }

//         public void CheckIshchi_soni()
//         {
//             if (ishchi_soni >= 20)
//                 ShowInfo();
//         }
//     }
// }