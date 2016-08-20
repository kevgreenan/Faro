using System;

namespace Faro
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Cards1 card = new Cards1();
			for (int i = 0; i < 1001; i = i + 2)
			{
				card.shuffle(i);
			}
		}
	}

	public class Cards1
	{
		public void shuffle(int size)
		{
			// initialize card array
			Cards card = new Cards();

			int[] cards = new int[size];
			int[] Newcards = new int[size];

			for (int i = 0; i < size; i++)
			{
				cards[i] = i + 1;
			}

			string original = "";
			for (int i = 0; i < size; i++)
			{
				original = original + cards[i];
			}

			bool flag = false;
			int count = 0;
			do
			{
				string c2 = "";
				Newcards = card.shuffle(size, cards);

				// convert arrays into strings
				for (int i = 0; i < size; i++)
				{
					c2 = c2 + Newcards[i];
				}

				count++;

				if (c2 == original)
				{
					flag = true;
				}

			} while (flag == false);
			Console.WriteLine(count);
		}
	}

	public class Cards
	{
		public int[] shuffle(int size, int[] cards)
		{

			int half = size / 2;

			int[] cards2 = new int[size];

			int[] array1 = new int[half];
			int[] array2 = new int[half];

			// cut the deck into two halves
			for (int i = 0; i < half; i++)
			{
				array1[i] = cards[i];
			}
			for (int i = 0; i < half; i++)
			{
				array2[i] = cards[i + half];
			}

			// put the deck together, alternating one half at a time, until it is in original order
			for (int i = 0; i < size; i++)
			{
				if (i % 2 == 0)
				{
					cards2[i] = array1[i / 2];
				}
				else {
					cards2[i] = array2[(i - 1) / 2];
				}
			}

			for (int i = 0; i < size; i++)
			{
				cards[i] = cards2[i];
			}

			return cards;

		}
	}
}

