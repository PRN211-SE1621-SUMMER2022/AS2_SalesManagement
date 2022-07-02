using BusinessObject.Models;
using DataAccess.Repository;
using System.Diagnostics;

namespace SalesWinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            MemberRepository memberRepository = new MemberRepository();
            Debug.WriteLine("Debug ne");
            IEnumerable<Member> result = memberRepository.GetAllMember();
            foreach(Member item in result.ToList())
            {
                Debug.WriteLine(item.City);
            }
            Debug.WriteLine("Debug ne ne");

                Application.Run(new frmLogin());
        }
    }
}