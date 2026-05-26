using Dumpify;

IEnumerable<int> listaNumeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

//Where
//listaNumeros.Where(num => num > 5).Dump("Números maiores que 5");

//Skip e Take
//listaNumeros.Skip(5).Dump("Números maiores que 5");
//listaNumeros.Take(5).Dump("Números menores ou iguais a 5");

//SkipLast e TakeLast
//listaNumeros.SkipLast(5).Dump("Números menores ou iguais a 5");
//listaNumeros.TakeLast(5).Dump("Números maiores que 5");

//SkipWhile e TakeWhile
//listaNumeros.SkipWhile(x => x < 5).Dump("Números maiores ou iguais a 5");
//listaNumeros.TakeWhile(x => x < 5).Dump("Números menores que 5");

//Chunk
//listaNumeros.Chunk(2).Dump("Números em grupos de 2");