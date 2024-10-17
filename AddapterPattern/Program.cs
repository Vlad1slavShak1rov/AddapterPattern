using AddapterPattern;

ComputerGame game = new ComputerGame("The Witcher 3", PegiAgeRating.P18, 100, 4096, 60, 8, 4, 3.5);

IPCGame pcGame = new ComputerGameAdapter(game);

Console.WriteLine("Название: " + pcGame.getTitle());
Console.WriteLine("Возраст: " + pcGame.getPegiAllowedAge());
Console.WriteLine("Triple-A: " + pcGame.isTripleAGame());
Console.WriteLine("Требования: " + pcGame.getRequirements());