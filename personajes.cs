namespace SpacePersonajes
{

    class Personajes
    {
        private string[] listaDeNombres = { "Charizard", "Bulbasaur", "Squirtle", "Raichu" };
        private tipos tipo;
        private string? nombre;
        private int velocidad;
        private int ataqueEspecial;
        private int defensaEspecial;
        private int ataque;
        private int defensa;
        private int hp;

        public tipos Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int AtaqueEspecial { get => ataqueEspecial; set => ataqueEspecial = value; }
        public int DefensaEspecial { get => defensaEspecial; set => defensaEspecial = value; }
        public int Ataque { get => ataque; set => ataque = value; }
        public int Defensa { get => defensa; set => defensa = value; }
        public int Hp { get => hp; set => hp = value; }
        public string[] ListaDeNombres { get => listaDeNombres;}

        public Personajes()
        {
        }

        //Propiedades

    }

}

public enum tipos
{
    fuego=0,
    planta=1,
    agua=2,
    electrico=3
}


// public enum tipos
// {
//     planta=1,
//     fuego=2,
//     agua=3,
//     normal=4,
//     lucha=5,
//     volador=6,
//     electrico=7,
//     tierra=8,
//     hielo=9,
//     acero=10,
//     hada=11,
//     veneno=12,
//     psiquico=13,
//     sieniestro=14,
//     bicho=15,
//     roca=16,
//     fantasma=17,
//     dragon=18
// }