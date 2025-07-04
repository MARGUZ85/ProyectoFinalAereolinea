using ProyectoFinalAereolinea.Backend;
using System;
using System.Collections.Generic;

namespace ProyectoFinalAereolinea.Backend
{
    public class DaoRegistro
    {
        public void GuardarRegistro(List<DaoUsuario> usuarios, List<string> asientos, string origen, string destino, DateTime fecha, TimeSpan hora)
        {
            if (usuarios == null || asientos == null || usuarios.Count != asientos.Count)
                throw new ArgumentException("Usuarios y asientos deben existir y tener igual cantidad.");

            for (int i = 0; i < usuarios.Count; i++)
            {
                int idUsuario = usuarios[i].Guardar();

                DaoBoleto boleto = new DaoBoleto
                {
                    IdUsuario = idUsuario,
                    Origen = origen,
                    Destino = destino,
                    Fecha = fecha,
                    Hora = hora,
                    Asiento = asientos[i],
                    NumeroTicket = Guid.NewGuid().ToString().Substring(0, 8)
                };

                boleto.Guardar();
            }
        }
    }
}
