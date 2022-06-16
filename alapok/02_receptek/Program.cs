using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// három per begépelése után automatikusan ad egy dokumentációs fejlécet
/// 
/// Feladat: kiírja a pörkölt hozzávainak listáját
/// code snipet: cw-t begépelve majd TAB -> kiírja a Console.WriteLine(); utasítást
/// 
/// Feladat kieg: heti egyszer (péntek) érkezik hal a piacra, akkor halas ételt eszünk, egyébkét pörköltet
/// 
/// feltétel vizsgálat:
/// 
/// ha (péntek van) akkor (halas recept) egyébként (pörkölt recept)
/// 
/// {}: kódblokk
/// 
/// sorok tömeges kommentje: kijelölés -> CTRL+K majd CTRL+C
/// 
/// nap megállapításához: .Net segítségével
/// 
/// a .-ok : CTRL+SPACE
/// javaslatok: CTRL+.
/// 
/// javaslat elfogadás: bal menüben amlelyik kell, kiválasztjuk vagy ENTER
/// 
/// metódus/függvény létrehozás:
/// 
/// kijelüljük a függvénybe kiemelt kód részletet, majd CTRL+. -> Extract method
/// 
/// Utólag ha módosul a függvény neve, a CTRL+.-al javítani lehet a teljes kódban a hibás függvényneveket az újra
/// 
/// </summary>

namespace _02_receptek
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            var maiNap = DateTime.Today;
            var maiNapNeve = maiNap.DayOfWeek;
            var maVanHalAPiacon = DayOfWeek.Thursday;

            AMegfeleloReceeptKiiratasa(maiNapNeve, maVanHalAPiacon);

            Console.ReadLine();
        }

        /// <summary>
        /// if-es rész extract method
        /// </summary>
        /// <param name="maiNapNeve"></param>
        /// <param name="maVanHalAPiacon"></param>
        private static void AMegfeleloReceeptKiiratasa(DayOfWeek maiNapNeve, DayOfWeek maVanHalAPiacon)
        {
            //if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)

            if (maiNapNeve == maVanHalAPiacon)
            {
                halasKiiratas();
            }
            else
            {
                marhasKiiratas();
            }
        }

        /// <summary>
        /// Egy pörkölt recept kiíratását végző függvény.
        /// 
        /// Honnan látható?
        /// private:    kívülről nem lehet meghívni, csak class-on belül
        /// internal:   projekten belül érvényes
        /// public:     mindenhonnan látszódik
        /// 
        /// static:     
        /// 
        /// void:       nincs visszatérési érték
        /// 
        /// függvény fölé visszük az egeret, a summary tartalma megjelenik
        /// 
        /// </summary>

        private static void marhasKiiratas()
        {
            Console.WriteLine("Marhahús");
            Console.WriteLine("Vöröshagyma");
            Console.WriteLine("Olaj");
            Console.WriteLine("Pirospaprika");
        }

        /// <summary>
        /// Egy halas recept kiíratását végző függvény.
        /// </summary>

        private static void halasKiiratas()
        {
            Console.WriteLine("Hal");
            Console.WriteLine("Vöröshagyma");
            Console.WriteLine("Olaj");
            Console.WriteLine("Pirospaprika");
        }
    }
}