using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Do you want to play some music?");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine($"Playing music...!");

                    using (SoundPlayer player = new SoundPlayer(@"C:\Users\plami\Desktop\work_folder2\PU_IntroCSharp_InClass1801681065\PUInClass\MusicPlayer\Music\KRISKO_feat._TITA_-_ISKAM_DA_BUDA_S_TEB_Official_Video-CJgX84o6-ac.wav")) ;
                    {
                        player.PlaySync();
                    }
                }
                else if (answer == "no")
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                }
            }
        }
    }


    

