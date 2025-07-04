string out_str = string.Empty;

for(int i = 0; i < 20; i++)
{
  char sym = Convert.ToChar(Random.Shared.Next(48, 122));
  out_str += sym;
}

while (true)
{
  Console.WriteLine(DateTime.Now + ": " + out_str);
  Thread.Sleep(5000);
}