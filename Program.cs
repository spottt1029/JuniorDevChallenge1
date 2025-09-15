namespace JuniorDevChallenge1
{
    internal class Program
    {
        static void Main()
        {
            // 建立兩個 List 來儲存學生姓名與成績
            List<string> names = new List<string>();
            List<int> grades = new List<int>();
            string again = "y";

            // 使用 while 迴圈允許使用者不斷輸入學生資料
            while (again.ToLower() == "y")
            {
                Console.WriteLine("請輸入學生姓名: ");
                string stu_name = Console.ReadLine(); // 讀取學生姓名
                names.Add(stu_name);

                Console.WriteLine("請輸入學生成績: ");
                int stu_grade = Convert.ToInt32(Console.ReadLine());
                grades.Add(stu_grade);

                while (true)
                {
                    Console.WriteLine("是否要輸入另一位學生？(Y/N)");
                    again = Console.ReadLine().Trim().ToLower();

                    if (again == "y" || again == "n")
                    {
                        break; // 正確回答才跳出這個小迴圈
                    }
                    else
                    {
                        Console.WriteLine("請回答 y 或 n !");
                    }
                }
            }

            // 根據學生成績輸出對應的等級
            for (int i = 0; i < names.Count; i++)
            {

                if (grades[i] > 100)
                {
                    Console.WriteLine("輸錯成績了");
                }
                else if (grades[i] >= 90)
                {
                    Console.WriteLine(names[i] + " 的成績是 A");
                }
                else if (grades[i] >= 80)
                {
                    Console.WriteLine(names[i] + " 的成績是 B");
                }
                else if (grades[i] >= 70)
                {
                    Console.WriteLine(names[i] + " 的成績是 C");
                }
                else if (grades[i] >= 60)
                {
                    Console.WriteLine(names[i] + " 的成績是 D");
                }
                else
                {
                    Console.WriteLine(names[i] + " 的成績是 F");
                }
            }
        }
    }

}
