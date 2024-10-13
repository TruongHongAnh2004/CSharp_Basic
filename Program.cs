using System.Text;
using QuanLyDiemHS;
public class Program
{
    //chắc chắn tạo danh sách đối tượng Student phải public 
    public static List<Student> students = new List<Student>();

    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        bool flag = true; //true là lặp liên tục
        while(flag)
        {
            Console.WriteLine("1. Nhập thông tin học sinh mới.");
            Console.WriteLine("2. Kiểm tra danh sách học sinh.");
            Console.WriteLine("3. Thoát.");
            Console.Write("Vui lòng chọn: ");
            int choose = int.Parse(Console.ReadLine());
            switch(choose)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    ListStudent();
                    break;
                default:
                    flag = false; //ta gán để kết thúc
                    break;
            }
        }
    }

    private static void AddStudent()
    {
        bool flag = true;
        while (flag)
        {
            Student hs = new Student();

            Console.Write("Nhập họ tên học sinh: ");
            hs.name = Console.ReadLine();

            hs.mathScore = hs.NhapDiemMonHoc(hs.name,"Toán");

            hs.englishScore = hs.NhapDiemMonHoc(hs.name, "Tiếng Anh");

            hs.scienceScore = hs.NhapDiemMonHoc(hs.name, "XH");

            students.Add(hs); //Thêm học sinh mới vào

            Console.WriteLine("1. Tiếp tục.");
            Console.WriteLine("2. Thoát.");

            Console.WriteLine("Vui lòng chọn: ");
            int choose =int.Parse(Console.ReadLine());  
            switch (choose)
            {
                case 1:
                    continue;
                default:
                    flag = false;  
                    break;

            }
        }
    }
    private static void ListStudent()
    {
        foreach(var hs in students)
        {
            Console.WriteLine($"Họ tên HS:{hs.name}");
            Console.WriteLine($"Điểm Toán: {hs.mathScore}");
            Console.WriteLine($"Điểm Anh: {hs.englishScore}");
            Console.WriteLine($"Điểm XH: {hs.scienceScore}");
            Console.WriteLine($"Điểm Trung Bình: {hs.AverageScore()}");
            Console.WriteLine($"Xếp loại HS là: {hs.GetClassification()}");

        }
    }
}
