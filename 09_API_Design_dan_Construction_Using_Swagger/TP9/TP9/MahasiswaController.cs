using Microsoft.AspNetCore.Mvc;
using tpmodul9_2311104044.Model;

namespace tpmodul9_2311104044.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Nama Kamu", Nim = "2311104044" },
            new Mahasiswa { Nama = "Teman 1", Nim = "2311104001" },
            new Mahasiswa { Nama = "Teman 2", Nim = "2311104002" }
        };

        [HttpGet]
        public ActionResult<List<Mahasiswa>> Get() => daftarMahasiswa;

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound("Index tidak ditemukan.");
            return daftarMahasiswa[index];
        }

        [HttpPost]
        public ActionResult<List<Mahasiswa>> Post([FromBody] Mahasiswa mhs)
        {
            daftarMahasiswa.Add(mhs);
            return daftarMahasiswa;
        }

        [HttpDelete("{index}")]
        public ActionResult<List<Mahasiswa>> Delete(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound("Index tidak ditemukan.");
            daftarMahasiswa.RemoveAt(index);
            return daftarMahasiswa;
        }
    }
}
