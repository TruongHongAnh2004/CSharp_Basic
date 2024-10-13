namespace QuanLyDiemHS;

public class Student
{
    
    public string name { get; set; }
    public float mathScore { get; set; }
    public float englishScore { get; set; }
    public float scienceScore { get; set; }

    public float AverageScore()
    {
        return (mathScore + englishScore + scienceScore) / 3.0f;
    }
    public string GetClassification()
    {
        float score = AverageScore();
        if (score >= 8.5)
        {
            return "Giỏi.";
        }
        else if (score >= 7.0)
        {
            return "Khá.";
        }
        else if (score >= 5.0)
        {
            return "Trung Bình.";
        }
        else
        {
            return "Yếu.";
        }
    }

    public float NhapDiemMonHoc(string name, string monhoc)
    {
        
        float diem;

        while (true)
        {
            try
            {
                Console.Write($"Nhập điểm môn {monhoc} của HS {name} là: ");
                diem = float.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Lỗi: Vui lòng nhập điểm bằng số!");
                Console.Write("Again");
            }
        }
        return diem;
    }
}