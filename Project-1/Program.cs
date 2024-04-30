using System.Xml.Serialization;

namespace Project_1
{
	public class Program
	{
		// Project 1. 숫자 입력 받아 여러 기능 구현하기
		// 프로젝트 설명 : 숫자를 입력받아 1번부터 n번까지의 기능을 모두 출력한다.
		// 선택지에서 0을 고르면 종료한다.
		// 1번은 논리연산자, 2번은 비트연산자, 3번은 함수오버로딩, 4번 배열

		// 1 : 각 기능 선택지 중 한 가지 선택지를 입력한다.
		//	   (형변환, 문자열 -> 숫자, 조건문 switch, 반복문 do while)
		// 3 : 1번 x보다 num이 큰지 작은지, 

		static void Main(string[] args)
		{
			int choice;
			do
			{
				choice = InsertNum();
				switch (choice)
				{
					case 1:
						break;
					case 2:
						break;
				}
			}
			while (choice == 0);
		}

		static public int InsertNum()
		{
			Console.WriteLine("숫자를 입력해주세요.");
			string temp = Console.ReadLine();
			return int.Parse(temp);
		}
	}
}
