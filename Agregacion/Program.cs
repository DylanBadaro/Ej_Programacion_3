using Agregacion;

//Creo jugadores
Jugador jugador1 = new Jugador("Lionel Messi", 10);
Jugador jugador2 = new Jugador("Cristiano Ronaldo", 7);

// Creo un equipo
Equipo equipo = new Equipo("Equipo A");

// Agrego jugadores al equipo
equipo.AgregarJugador(jugador1);
equipo.AgregarJugador(jugador2);

// Muestra información del equipo y sus jugadores
Console.WriteLine($"Equipo: {equipo.Nombre}");
foreach (var jugador in equipo.Jugadores)
{
    Console.WriteLine($"Jugador: {jugador.Nombre}, Camiseta #{jugador.NumeroCamiseta}");
}

/*, la clase Jugador representa a un jugador de fútbol con su nombre y número de camiseta. 
 La clase Equipo representa un equipo de fútbol y tiene una lista de jugadores como atributo. 
 La relación entre el equipo y los jugadores es una relación de agregación, ya que los jugadores 
 pueden existir independientemente del equipo.*/