using desafiodio.models;

Pessoa p1= new Pessoa("John","Doe");
Pessoa p2= new Pessoa("Jane","Doe");

List<Pessoa> listaPessoas= new List<Pessoa>();
listaPessoas.Add(p1);
listaPessoas.Add(p2);

Suite s1= new Suite("luxo",1,100M);

Reserva r1= new Reserva(listaPessoas,s1,10);

Console.WriteLine(r1.CalcularValor());

r1.cadastrarHospedes(listaPessoas);

