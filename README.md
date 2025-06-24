# E-commerce-Job-testA&W
## Project ini merupakan Project Test Kemampuan untuk proses seleksi A&W dengan menggunakan C# dan ASP .NET Core
## Project ini mempunyai beberapa Fitur Utama yang harus dibuat Seperti:
1. Halaman Produk
2. Halaman Keranjang
3. Halaman Checkout
4. Webhook Endpoint
---
## Fitur Utama yang terdapat dalam project ini adalah:
1. Halaman Produk
2. Halaman Keranjang
3. Halaman Checkout
---
Project ini mempunyai Migrasi Database, untuk menggunakannya anda harus mempunyai EntityFrameworkCore(SQL Server & Tools) yang dapat diunduh di NuGet Package Manager dengan cara:
1. Klik kanan pada project
2. Klik Manage NuGet Package
3. Cari Entityframework
4. Unduh beberapa package:
   - EntityFrameworkCore
   - EntityFrameworkCore.SQLServer
   - EntityFrameworkCore.Tools

Setelah mengunduh Package, anda dapat migrasi ke database SQL Server anda dengan menggunakan syntax berikut: **Update-Database**
---
## Cara Simulasi Pembayaran Midtrans
1. buka https://simulator.sandbox.midtrans.com
2. tekan tombol Pay yang berada di website project ini terdapat di halaman Checkout.
3. Pilih metode pembayarannya
4. kembali ke https://simulator.sandbox.midtrans.com carilah metode pembayaran yang di inginkan
5. masukkan VA / QR code ke dalam input
6. tekan simulasi pembayaran hingga selesai
7. kembali ke website project ini dan tekan tombol check status
8. Pembayaran Selesai
