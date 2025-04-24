using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using tpmodul9_2311104042.Models;

namespace tpmod9_2311104042.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
       
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
 {
 new Mahasiswa { Nama = "Tiur", Nim = "2311104042" },
 new Mahasiswa { Nama = "farhan", Nim = "2311104016" },
 new Mahasiswa { Nama = "candra", Nim = "2311104020" }
 };
        
        [HttpGet]
        public ActionResult<List<Mahasiswa>> Get()
        {
            return daftarMahasiswa;
        }
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();
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
                return NotFound();
            daftarMahasiswa.RemoveAt(index);
            return daftarMahasiswa;
        }
    }
}