using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public class Wisudawan
{
    public string kode_fak { get; set; }
    public string fakultas { get; set; }
    public string kode_jur { get; set; }
    public string jurusan { get; set; }
    public string nim { get; set; }
    public string nama { get; set; }
    public string ipk { get; set; }
    public string predikat { get; set; }
    public string tgl_sidang { get; set; }
    public string judul { get; set; }
    public string pembimbing1 { get; set; }
    public string pembimbing2 { get; set; }
    public string gelar_s1 { get; set; }
    public string email { get; set; }
}

public class Data
{
    public List<Wisudawan> wisudawan { get; set; }
}

public class Root
{
    public bool status { get; set; }
    public Data data { get; set; }
}

public class Program
{
    public static void Main()
    {
        string json = @"
        {
  ""status"": true,
  ""data"": {
    ""wisudawan"": [
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1167050089"",
        ""nama"": ""LITA ARINDA"",
        ""ipk"": ""3.51"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-08-31"",
        ""judul"": ""Augmented Reality Pembelajaran Anatomi Otak Manusia dengan Algoritma FAST Corner Detection"",
        ""pembimbing1"": ""Ichsan Taufik- ST.- MT."",
        ""pembimbing2"": ""Aldy Rialdy Atmadja- MT."",
        ""gelar_s1"": ""ST."",
        ""email"": ""litaarinda98@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1167050093"",
        ""nama"": ""MOHAMMAD ARIF SODIKIN"",
        ""ipk"": ""3.02"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-06-09"",
        ""judul"": ""Implementasi Algoritma PaillierÂ  Cryptosystem pada Fitur Image signature"",
        ""pembimbing1"": ""ARIEF FATCHUL HUDA"",
        ""pembimbing2"": ""Diena Rauda Ramdania- S.Pd.- MT.- M.Eng."",
        ""gelar_s1"": ""ST."",
        ""email"": ""arrifsa.career@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1167050155"",
        ""nama"": ""SRI DESI MULYANI"",
        ""ipk"": ""3.39"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-08-29"",
        ""judul"": ""Implementasi Teknologi Olap -Online Analytical Processing- pada Sistem Pengolahan Data Wisudawan -Study Kasus: Uin Sunan Gunung Djati Bandung-"",
        ""pembimbing1"": ""Jumadi- ST.- M.Cs."",
        ""pembimbing2"": ""Gitarja Sandi- M.T."",
        ""gelar_s1"": ""ST."",
        ""email"": ""sridesimulyani@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1177050006"",
        ""nama"": ""Adjie Wafi"",
        ""ipk"": ""3.81"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-10-30"",
        ""judul"": ""Implementasi MetodeÂ Rule BasedÂ danÂ Fuzzy String MatchingÂ pada Aplikasi Konsultasi Kesehatan Berbasis Telegram"",
        ""pembimbing1"": ""Jumadi- ST.- M.Cs."",
        ""pembimbing2"": ""Diena Rauda Ramdania- S.Pd.- MT.- M.Eng."",
        ""gelar_s1"": ""ST."",
        ""email"": ""adjiewafi@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1177050018"",
        ""nama"": ""Ari Rahmat Yunast"",
        ""ipk"": ""3.27"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-08-30"",
        ""judul"": ""Rancang Bangun Sistem Keamanan Pintu - Smarthome - Berbasis Internet of Things"",
        ""pembimbing1"": ""Nur Lukman- ST. M.Kom"",
        ""pembimbing2"": ""Edi Mulyana- ST.- MT.- MT"",
        ""gelar_s1"": ""ST."",
        ""email"": ""uden2424@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1177050061"",
        ""nama"": ""Miftahul Jannah"",
        ""ipk"": ""3.64"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2024-01-26"",
        ""judul"": ""Perbandingan Algoritma Linear Congruential Generator- Naive Shuffle- dan Fisher Yates Shuffle pada Game Edukasi Asmaâ€™ul Husna Berbasis Android"",
        ""pembimbing1"": ""Dr. Cepy Slamet- S.T.- M.Kom."",
        ""pembimbing2"": ""Diena Rauda Ramdania- S.Pd.- MT.- M.Eng."",
        ""gelar_s1"": ""ST."",
        ""email"": ""miftahuljannah.bie@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1177050067"",
        ""nama"": ""Muhammad Aqil Almuhtadi"",
        ""ipk"": ""3.36"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-12-27"",
        ""judul"": ""Implementasi Tanda Tangan Digital Menggunakan Algoritma Keccak denganÂ Rivest-Shamir -Â AdlemanÂ Dan Chacha20"",
        ""pembimbing1"": ""Ichsan Taufik- ST.- MT."",
        ""pembimbing2"": ""Agung Wahana- S.E.- M.T."",
        ""gelar_s1"": ""ST."",
        ""email"": ""1177050067@student.uinsgd.ac.id""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1177050068"",
        ""nama"": ""Muhammad Azka Khowarizmi"",
        ""ipk"": ""3.49"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-12-21"",
        ""judul"": ""Sistem Pendeteksi Penyakit Daun Kentang Menggunakan AlgoritmaÂ You Only Look OnceÂ -YOLO-"",
        ""pembimbing1"": ""Jumadi- ST.- M.Cs."",
        ""pembimbing2"": ""Popon Dauni- ST. M.Kom"",
        ""gelar_s1"": ""ST."",
        ""email"": ""azkakhowarizmi@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1187050007"",
        ""nama"": ""AHMAD KAMAL"",
        ""ipk"": ""3.58"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-10-31"",
        ""judul"": ""Deteksi Kata Sarkasme Berbahasa Indonesia pada Teks di Media Sosial X dengan Menggunakan Multinomial Naive Bayes"",
        ""pembimbing1"": ""Dian Sa-adillah Maylawati- S.Kom.- M.T.- Ph.D"",
        ""pembimbing2"": ""Eva Nurlatifah- M.Sc."",
        ""gelar_s1"": ""ST."",
        ""email"": ""ahmaddkml@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1187050029"",
        ""nama"": ""FADLI ALFA RIZKI"",
        ""ipk"": ""3.6"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-11-21"",
        ""judul"": ""Penerapan Algoritma Convolutional Neural Network Menggunakan YOLOv8 untuk Melakukan Segmentasi Semantik pada Senjata Api"",
        ""pembimbing1"": ""Mohamad Irfan- ST.- M.Kom.- Ph.D"",
        ""pembimbing2"": ""Dr. Dian Sa-adillah Maylawati- S.Kom.- M.T."",
        ""gelar_s1"": ""ST."",
        ""email"": ""1187050029@student.uinsgd.ac.id""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1187050065"",
        ""nama"": ""MUHAMMAD AKBAR HADIQ"",
        ""ipk"": ""3.54"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-10-31"",
        ""judul"": ""Pengukuran Akurasi Proses Deteksi Objek dan Konversi Citra ke Teks pada Tanda Nomor Kendaraan Bermotor -TNKB- Menggunakan YOLOV5 dan PaddleOCR"",
        ""pembimbing1"": ""Ichsan Taufik- ST.- MT."",
        ""pembimbing2"": ""Jumadi- ST.- M.Cs."",
        ""gelar_s1"": ""ST."",
        ""email"": ""akbarhadiq.ha@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1197050001"",
        ""nama"": ""Abdiladif Ali Ahmed"",
        ""ipk"": ""3.26"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-10-24"",
        ""judul"": ""Development of a web-based online medicine delivery system. case-study Moumin Pharma -Somalia"",
        ""pembimbing1"": ""- Undang Syaripudin- M.Kom."",
        ""pembimbing2"": ""Jumadi- ST.- M.Cs."",
        ""gelar_s1"": ""ST."",
        ""email"": ""badalnolashada123@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1197050003"",
        ""nama"": ""Abdullahi Jama Farah"",
        ""ipk"": ""3.2"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-10-24"",
        ""judul"": ""food ordering management system for golis restaurant"",
        ""pembimbing1"": ""Jumadi- ST.- M.Cs."",
        ""pembimbing2"": ""M. Deden Firdaus- ST.-"",
        ""gelar_s1"": ""ST."",
        ""email"": ""abdillahijamafarah@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1197050014"",
        ""nama"": ""Andi Malia Fadilah Bahari"",
        ""ipk"": ""3.92"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-12-12"",
        ""judul"": ""Perbandingan Akurasi Deteksi Baris Min-Cost Flow Network dan Tesseract Pada Citra Digital Berdasarkan Perbedaan Metode Segmentasi"",
        ""pembimbing1"": ""Dr. Cepy Slamet- S.T.- M.Kom."",
        ""pembimbing2"": ""Agung Wahana- S.E.- M.T."",
        ""gelar_s1"": ""ST."",
        ""email"": ""011007andimalia@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1197050015"",
        ""nama"": ""Andin Aprila Sari"",
        ""ipk"": ""3.86"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-12-21"",
        ""judul"": ""Analisis Sentimen Terhadap Review Pengguna Web Profile Jurusan Teknik Informatika Menggunakan Algoritma Long Short-TermÂ MemoryÂ -LSTM-"",
        ""pembimbing1"": ""Dr. Wisnu Uriawan- ST.- M.Kom."",
        ""pembimbing2"": ""Ichsan Budiman- MT"",
        ""gelar_s1"": ""ST."",
        ""email"": ""andinaprila19@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1197050018"",
        ""nama"": ""Annisa Sugi Pramesty"",
        ""ipk"": ""3.84"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-11-01"",
        ""judul"": ""Performance Algoritma BERT pada Analisis Sentimen terhadap Perlindungan Hak Tenaga KerjaÂ diÂ Indonesia"",
        ""pembimbing1"": ""Dian Sa-adillah Maylawati- S.Kom.- M.T.- Ph.D"",
        ""pembimbing2"": ""Diena Rauda Ramdania- S.Pd.- MT.- M.Eng."",
        ""gelar_s1"": ""ST."",
        ""email"": ""annisazyn@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1197050052"",
        ""nama"": ""Intan Permata Sari"",
        ""ipk"": ""3.85"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-12-22"",
        ""judul"": ""Augmented RealityÂ Pembelajaran Kisah Nabi dan Rasul Menggunakan AlgoritmaÂ FAST Corner Detection"",
        ""pembimbing1"": ""Aldy Rialdy Atmadja- MT."",
        ""pembimbing2"": ""Muhammad Insan Al Amin- MT"",
        ""gelar_s1"": ""ST."",
        ""email"": ""intanpermatas1605@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1197050054"",
        ""nama"": ""IQBAL PUTRA RAMADHAN"",
        ""ipk"": ""3.83"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-12-22"",
        ""judul"": ""Implementasi Algoritma Convolutional Neural Network dengan Arsitektur Vgg-16 untuk Klasifikasi Gambar Benda Bahasa Arab"",
        ""pembimbing1"": ""Dian Sa-adillah Maylawati- S.Kom.- M.T.- Ph.D"",
        ""pembimbing2"": ""Diena Rauda Ramdania- S.Pd.- MT.- M.Eng."",
        ""gelar_s1"": ""ST."",
        ""email"": ""iqbalputra2892015@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1197050057"",
        ""nama"": ""Jidan Ramdani"",
        ""ipk"": ""3.67"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-11-14"",
        ""judul"": ""Penerapan Metode Klasifikasi C4.5 Untuk Prediksi Akun Tepercaya Pada Media Sosial TikTok"",
        ""pembimbing1"": ""Dr. Wisnu Uriawan- ST.- M.Kom."",
        ""pembimbing2"": ""Muhammad Deden Firdaus- ST- M.Kom"",
        ""gelar_s1"": ""ST."",
        ""email"": ""ramdanijidan123@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1197050060"",
        ""nama"": ""LAELA CHINTIA ALVIANI"",
        ""ipk"": ""3.66"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-12-28"",
        ""judul"": ""Perancangan Sistem Prediksi Kurs Rupiah Terhadap Dolar Amerika MenggunakanÂ Autoregressive Integrated Moving AverageÂ -Arima-"",
        ""pembimbing1"": ""Dr. Wisnu Uriawan- ST.- M.Kom."",
        ""pembimbing2"": ""Muhammad Insan Al Amin- MT"",
        ""gelar_s1"": ""ST."",
        ""email"": ""laelachintia2006@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1197050074"",
        ""nama"": ""Mohamed Abdullahi Mohamed"",
        ""ipk"": ""3.26"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-12-28"",
        ""judul"": ""Pharmacy Management System"",
        ""pembimbing1"": ""Dr. Cepy Slamet- S.T.- M.Kom."",
        ""pembimbing2"": ""Cecep Nurul Alam- M.T."",
        ""gelar_s1"": ""ST."",
        ""email"": ""ainshezbtwelve@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1197050077"",
        ""nama"": ""Muhamad Krisnandi"",
        ""ipk"": ""3.69"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-10-30"",
        ""judul"": ""Implementasi Algoritma Artificial Neural Network pada Chatbot Informasi Objek Wisata Di Kabupaten Bandung"",
        ""pembimbing1"": ""Wisnu Uriawan- ST.- M.Kom."",
        ""pembimbing2"": ""Wildan Budiawan Zulfikar- S.T.- M.Kom."",
        ""gelar_s1"": ""ST."",
        ""email"": ""muhamad.krisnandi.22@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1197050095"",
        ""nama"": ""Naufal Rizqullah"",
        ""ipk"": ""3.94"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-12-15"",
        ""judul"": ""Pengembangan Teknologi Analisis Sentimen untuk Kementerian Agama MenggunakanÂ Reinforced Multinomial NaÃ¯ve Bayes Classifier"",
        ""pembimbing1"": ""Prof. Dr. H. M. Ali Ramdhani- S.TP.- MT."",
        ""pembimbing2"": ""Dr. Dian Sa-adillah Maylawati- S.Kom.- M.T."",
        ""gelar_s1"": ""ST."",
        ""email"": ""naufalrizqullah23@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1197050132"",
        ""nama"": ""Yahye Mohamed Ahmed Ali"",
        ""ipk"": ""3.33"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-10-31"",
        ""judul"": ""Web-Based Payroll Management System Case Study Telesom Company"",
        ""pembimbing1"": ""Dr. Wisnu Uriawan- ST.- M.Kom."",
        ""pembimbing2"": ""Ichsan Budiman- MT"",
        ""gelar_s1"": ""ST."",
        ""email"": ""yahye4843@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1197050133"",
        ""nama"": ""YUNITA MINARNI"",
        ""ipk"": ""3.61"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-12-12"",
        ""judul"": ""Aplikasi Pembelajaran Imla Menggunakan Algoritma Fast Corner Detection dan Natural Feature Tracking Berbasis Augmented Reality"",
        ""pembimbing1"": ""H. Aldy Rialdy Atmadja- M.T"",
        ""pembimbing2"": ""Eva Nurlatifah- M.Sc."",
        ""gelar_s1"": ""ST."",
        ""email"": ""yunitaminarni12@gmail.com""
      },
      {
        ""kode_fak"": ""7"",
        ""fakultas"": ""SAINS DAN TEKNOLOGI"",
        ""kode_jur"": ""705"",
        ""jurusan"": ""TEKNIK INFORMATIKA"",
        ""nim"": ""1197050135"",
        ""nama"": ""Dekis Aldamawan"",
        ""ipk"": ""3.74"",
        ""predikat"": ""Sangat Memuaskan"",
        ""tgl_sidang"": ""2023-12-18"",
        ""judul"": ""Deteksi Iklan Judi Online pada Gambar Dengan Algoritma Faster R-Cnn"",
        ""pembimbing1"": ""Jumadi- ST.- M.Cs."",
        ""pembimbing2"": ""Gitarja Sandi - S.T.- M.T."",
        ""gelar_s1"": ""ST."",
        ""email"": ""dekisaldamawan12@gmail.com""
      }
    ]
  }
}";

        Root rootObject = JsonConvert.DeserializeObject<Root>(json);
        List<Wisudawan> wisudawanList = rootObject.data.wisudawan;

        // Menampilkan data wisudawan
        foreach (var wisudawan in wisudawanList)
        {
            Console.WriteLine($"Nama: {wisudawan.nama}, NIM: {wisudawan.nim}, IPK: {wisudawan.ipk}");
        }
    }
}
