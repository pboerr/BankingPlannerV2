using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.BulkInsert.Extensions;

namespace BL
{
    public class ConnectedRepository
    {

        //public BankingPlannerEntities context = new BankingPlannerEntities();

        //public List<ParametroDemanda> ObtenerParametrosDemandaSite(SimSite simSite)
        //{

        //    List<ParametroDemanda> output = new List<ParametroDemanda>();
        //    try
        //    {


        //        using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString))
        //        {

        //            SqlCommand cmd = new SqlCommand("carga_parametros_demanda", cn);
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //            SqlParameter prSimSite = new SqlParameter("@SimSite", SqlDbType.Int);
        //            prSimSite.Value = simSite.id;
        //            cmd.Parameters.Add(prSimSite);
        //            cmd.CommandTimeout = 120;
        //            cn.Open();
        //            SqlDataReader reader = cmd.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                ParametroDemanda nuevoRegistro = new ParametroDemanda
        //                {
        //                    SimDemandaId = Convert.ToInt32(reader["sim_demanda"]),
        //                    sim_seccion = Convert.ToInt32(reader["sim_seccion"]),
        //                    tipo_servicio = Convert.ToInt32(reader["tipo_servicio"]),
        //                    tipo_cliente = Convert.ToInt32(reader["sim_tipo_cliente"]),
        //                    dtHora = Convert.ToDateTime(reader["dtHora"]),
        //                    media_llegadas = Convert.ToSingle(reader["media_llegadas"]),
        //                    media_atencion_sec = Convert.ToInt32(reader["media_atencion_sec"]),
        //                    desvio_atencion_sec = Convert.ToInt32(reader["desvio_atencion_sec"]),
        //                    limite_atencion_sec = Convert.ToInt32(reader["limite_atencion_sec"]),
        //                    media_espera = Convert.ToInt32(reader["media_espera"]),
        //                    desvio_espera = Convert.ToInt32(reader["desvio_espera"]),
        //                    sla = Convert.ToInt32(reader["sla"]),
        //                    prioridad = Convert.ToInt32(reader["prioridad"])
        //                };

        //                nuevoRegistro.SimDemanda = context.sim_demanda.Where(x => x.id == nuevoRegistro.SimDemandaId).FirstOrDefault();

        //                output.Add(nuevoRegistro);
        //            }

        //        }

        //        return output;

        //    }
        //    catch
        //    {
        //        return output;
        //    }

        //}
        //public SimSiteCalc ObtenerSite(int siteId)
        //{
        //    var simSiteModel = context.sim_sites
        //                                .Where(s => s.id == siteId)
        //                                .FirstOrDefault();

        //    SimSiteCalc nuevoSite = new SimSiteCalc(simSiteModel);

        //    return nuevoSite;
        //}
        //public Queue<SimDemandaCalc> GenerarQueueSimDemandaCalculada(SimSite site)
        //{
        //    try
        //    {
        //        var Statistics = new Statistics();

        //        List<ParametroDemanda> listaParametrosDemanda = new List<ParametroDemanda>();
        //        listaParametrosDemanda = this.ObtenerParametrosDemandaSite(site);
        //        //Si no tenemos parametros de input, devolvemos una fila vacia.
        //        if (listaParametrosDemanda.Count == 0)
        //        {
        //            return null;
        //        }

        //        List<SimDemandaCalc> listaDemandas = new List<SimDemandaCalc>();
        //        DateTime hora;
        //        DateTime limiteHora;
        //        double mediaIntervaloLlegadas;
        //        double secEntreLlegadas;

        //        foreach (var pd in listaParametrosDemanda.OrderBy(x => x.sim_seccion).OrderBy(x => x.tipo_servicio).OrderBy(x => x.tipo_cliente).OrderBy(x => x.dtHora))
        //        {

        //            hora = pd.dtHora;
        //            limiteHora = pd.dtHora.AddMinutes(30);
        //            mediaIntervaloLlegadas = pd.media_llegadas > 0 ? 3600.0 / pd.media_llegadas : 1000000;

        //            do
        //            {

        //                secEntreLlegadas = Statistics.Poisson(mediaIntervaloLlegadas);
        //                hora = hora.AddSeconds(secEntreLlegadas);
        //                if (hora < limiteHora)
        //                {
        //                    SimDemandaCalc nuevaDemanda = new SimDemandaCalc(pd.SimDemandaId, pd.SimDemanda, hora);
        //                    listaDemandas.Add(nuevaDemanda);
        //                }
        //            } while (hora < limiteHora);
        //        }

        //        return new Queue<SimDemandaCalc>(listaDemandas.OrderBy(x => x.DtIngreso));

        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}
        //public void GuardarCambios()
        //{          
        //    context.SaveChanges();
        //}
        //public void GuardarListSimDemandaCalculadaEgresadas(SimSite site)
        //{
        //    List<SimDemandaCalc> listaSalida = new List<SimDemandaCalc>();
        //    var qry = site.FilaLlegadas;//site.SimSeccionICollection.SelectMany(x => x.ListaEgresos());
        //    listaSalida.AddRange(qry);

        //    try
        //    {


        //        using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString))
        //        {

        //            SqlBulkCopy bulkCopy = new SqlBulkCopy(cn);
        //            bulkCopy.DestinationTableName = "SimDemandasCalculadas";
        //            DataTable convertedDataTable = ConvertToDataTable<SimDemandaCalc>(listaSalida);
        //            cn.Open();
        //            bulkCopy.WriteToServer(convertedDataTable);
        //            cn.Close();
        //        }

        //    }
        //    catch
        //    {

        //    }

        //}
        //public DataTable ConvertToDataTable<T>(IList<T> data)
        //{
        //    PropertyDescriptorCollection properties =
        //       TypeDescriptor.GetProperties(typeof(T));
        //    DataTable table = new DataTable();
        //    foreach (PropertyDescriptor prop in properties)
        //        table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
        //    foreach (T item in data)
        //    {
        //        DataRow row = table.NewRow();
        //        foreach (PropertyDescriptor prop in properties)
        //            row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
        //        table.Rows.Add(row);
        //    }
        //    return table;

        //}

        //public HashSet<sim_secciones> GenerarHashSetSeccionesEspera(sim_sites siteEspera)
        //{

        //    var hashSet = new HashSet<sim_secciones>(context.sim_sites.Where(s => s.id == siteEspera.id).FirstOrDefault().sim_secciones.ToList());

        //    HashSet<SeccionEspera> hashSetSeccionEspera = new HashSet<SeccionEspera>();

        //    foreach(var simSeccion in hashSet)
        //    {
        //        hashSetSeccionEspera.Add(new SeccionEspera(siteEspera, simSeccion));
        //    }

        //    return hashSetSeccionEspera;

        //}

        //public HashSet<FilaEspera> GenerarHashSetFilasEspera(sim_secciones seccion)
        //{
        //    var tmp = seccion.sim_demanda.GroupBy(tc => tc.sim_tipos_cliente).Select(u => u.First()).Select(u => u.sim_tipos_cliente).ToList();

        //    List<sim_demanda> listaDemandas = new List<sim_demanda>();
        //    foreach(var sec in listaSimSecciones)
        //    {
        //        listaDemandas.AddRange(sec.sim_demanda.GroupBy(n => n.sim_tipos_cliente).Select(u => u.First()).ToList());
        //    }

        //    var IEnumerableSimTipoCliente = listaDemandas.GroupBy(x => x.sim_tipos_cliente).Select(x => x.FirstOrDefault()).Select(x => x.sim_tipos_cliente);

        //    HashSet<FilaEspera> hashSetFilaEspera = new HashSet<FilaEspera>();

        //    foreach(var simFila in IEnumerableSimTipoCliente)
        //    {
        //        hashSetFilaEspera.Add(new FilaEspera(seccion, simFila));
        //    }

        //    return hashSetFilaEspera;

        //}

        //public void AgregarSimDemandaCalculada(SimDemandaCalculada nuevaDemanda)
        //{
        //    context.SimDemandasCalculadas.Add(nuevaDemanda);
        //}
        //public void GuardarListSimDemandaCalculadaEgresadas(SimSite site)
        //{
        //    List<SimDemandaCalculada> listaSalida = new List<SimDemandaCalculada>();
        //    var qry = site.FilaLlegadas;//site.SimSeccionICollection.SelectMany(x => x.ListaEgresos());
        //    listaSalida.AddRange(qry);

        //    try
        //    {


        //        using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString))
        //        {

        //            SqlBulkCopy bulkCopy = new SqlBulkCopy(cn);
        //            bulkCopy.DestinationTableName = "SimDemandasCalculadas";
        //            DataTable convertedDataTable = ConvertToDataTable<SimDemandaCalculada>(listaSalida);
        //            cn.Open();
        //            bulkCopy.WriteToServer(convertedDataTable);
        //            cn.Close();
        //        }

        //    }
        //    catch
        //    {

        //    }

        //}
    }
}
