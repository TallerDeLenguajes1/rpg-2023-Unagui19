using SpacePersonajes;

namespace EspacioFabrica
{
    class fabricaDePersonajes
    {
        // int limite=500;
        // Personajes player=new Personajes();

        public void datos(Personajes player)
        {   
            int nomAux=new Random().Next(0,3);
            player.Nombre=player.ListaDeNombres[nomAux];
            switch (nomAux)
            {
                case 0: player.Tipo=tipos.fuego;
                break;
                case 1: player.Tipo=tipos.planta;
                break;
                case 2: player.Tipo=tipos.agua;
                break;
                case 3: player.Tipo=tipos.electrico;
                break;
            }
        }
        public void caracteristicas(Personajes player)
        {
            player.Hp= new Random().Next(0,100); 
            player.Ataque=new Random().Next(0,100);
            player.Defensa= new Random().Next(0,100);
            player.AtaqueEspecial= new Random().Next(0,100);
            player.DefensaEspecial= new Random().Next(0,100);
        }       
        
        static public void mostrar(Personajes player)
        {
            Console.WriteLine(player.Nombre);
        }

    }
}