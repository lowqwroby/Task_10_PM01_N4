using System;
using System.IO;

namespace Variant
{
	class Program
	{

		static void z10(string Path)
		{
			//1 задание
			Directory.CreateDirectory(Path + @"\K1");
		Console.WriteLine("Папка K1 создана.");
			Directory.CreateDirectory(Path + @"\K2");
		Console.WriteLine("Папка K2 создана.\n");	
			//2 задание
			File.Create(Path + @"\K1\t1.txt").Close();
		Console.WriteLine("Файл t1.txt создан.");
			string t1 = "Мокеева Дарья Алексеевна, 2004 года рождения, место жительства г. Владимир.\n";
			File.WriteAllText(Path + @"\K1\t1.txt", t1);
		Console.WriteLine("В файл t1.txt записан текст.\n");
			File.Create(Path + @"\K1\t2.txt").Close();
		Console.WriteLine("Файл t2.txt создан.");
			string t2 = "Мальцева Ксения Александровна, 1992 года рождения, место жительства г. Москва.\n";
			File.WriteAllText(Path + @"\K1\t2.txt", t2);
		Console.WriteLine("В файл t2.txt записан текст.\n");
			//3 задание
			File.Create(Path + @"\K2\t3.txt").Close();
		Console.WriteLine("Файл t3.txt был создан.");
			File.WriteAllText(Path + @"\K2\t3.txt", File.ReadAllText(Path + @"\K1\t1.txt"));
			File.AppendAllText(Path + @"\K2\t3.txt", File.ReadAllText(Path + @"\K1\t2.txt"));
		Console.WriteLine("В файл t3.txt записан текст.\n");
			//4 задание
			FileInfo f1 = new FileInfo(@"C:\temp\K1\t1.txt");
			FileInfo f2 = new FileInfo(@"C:\temp\K1\t2.txt");
			FileInfo f3 = new FileInfo(@"C:\temp\K2\t3.txt");
		Console.WriteLine($"Имя файла: {f1.Name}\nВремя создания: {f1.CreationTime}\nРазмер: {f1.Length}\n\n");
		Console.WriteLine($"Имя файла: {f2.Name}\nВремя создания: {f2.CreationTime}\nРазмер: {f2.Length}\n\n");
		Console.WriteLine($"Имя файла: {f3.Name}\nВремя создания: {f3.CreationTime}\nРазмер: {f3.Length}\n");
			//5-6 задание
			f2.MoveTo(@"C:\temp\K2\t2.txt");
		Console.WriteLine("Файл t2.txt был перемещен в папку K2");
			f1.CopyTo(@"C:\temp\K2\t1.txt");
		Console.WriteLine("Файл t1.txt был скопирован в папку K2\n");
			//7 задание
			Directory.Move(@"C:\temp\K2", @"C:\temp\ALL");
		Console.WriteLine("Папка K2 была переименована в All.");
			File.Delete(@"C:\temp\K1\t1.txt");
			Directory.Delete(@"C:\temp\K1");
		Console.WriteLine("Папка K1 была удалена\n");
			//8 Задание
			DirectoryInfo dinf = new DirectoryInfo(@"C:\temp\ALL");
			FileInfo[] finf = dinf.GetFiles();

			foreach(FileInfo f in finf)
			{
				Console.WriteLine("Полное имя файла: " + f.FullName.ToString());
				Console.WriteLine("Атрибуты: " + f.Attributes.ToString());
				Console.WriteLine("Существует ли файл: " + f.Exists.ToString());
				Console.WriteLine("Размер файла: " + f.Length.ToString());
				Console.WriteLine("Расширение файла: " + f.Extension.ToString() + "\n\n");
			}
		}
		static void Main()
		{
			try
			{
				string Path = @"C:\temp";
				if (Directory.Exists(Path))
				{
					z10(Path);
				}
				else
				{
					Directory.CreateDirectory(Path);
					z10(Path);
				}
			}
			catch
			{
				Console.WriteLine("Ошибка");
			}
		}
	}
}