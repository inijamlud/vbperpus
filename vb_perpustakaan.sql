-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 14, 2021 at 10:24 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `vb_perpustakaan`
--

-- --------------------------------------------------------

--
-- Table structure for table `anggota`
--

CREATE TABLE `anggota` (
  `id_anggota` varchar(20) NOT NULL,
  `nama_anggota` varchar(255) NOT NULL,
  `alamat` varchar(255) NOT NULL,
  `telp_anggota` varchar(13) NOT NULL,
  `email_anggota` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `anggota`
--

INSERT INTO `anggota` (`id_anggota`, `nama_anggota`, `alamat`, `telp_anggota`, `email_anggota`) VALUES
('A001', 'Jamal', 'Purwakarta', '0258900082', 'jamalude449@gmail.com'),
('A002', 'Jeki', 'Purwakarta', '087790928789', 'jeki@mail.com'),
('A003', 'ulil', 'cibening', '08792982716', 'ulil@mail.com'),
('A005', 'rafy zs', 'munjul', '087790188927', 'arafymil@mil.c'),
('A006', 'abigel', 'jakarta', '087976567263', 'abigel@mail.com'),
('A007', 'Abdel Temon', 'Jakarta', '089790913431', 'Abdel.temon@mail.com');

-- --------------------------------------------------------

--
-- Table structure for table `buku`
--

CREATE TABLE `buku` (
  `id_buku` varchar(20) NOT NULL,
  `judul` varchar(255) NOT NULL,
  `pengarang` varchar(255) NOT NULL,
  `penerbit` varchar(255) NOT NULL,
  `tahun` varchar(4) NOT NULL,
  `jml_hal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `buku`
--

INSERT INTO `buku` (`id_buku`, `judul`, `pengarang`, `penerbit`, `tahun`, `jml_hal`) VALUES
('B001', 'Buaya & Kancil', 'Mandeka', 'Gramedia Pusat1', '2018', 39),
('B003', 'Selamat File Kompres', 'Kesek Grodi', 'Libra Minim artikel', '2017', 128),
('B004', 'Teamwork for success', 'John Mandre', 'Gramedia', '2015', 300),
('B005', '1000 Obat Alami Herbal', 'KH. Marhadi', 'Gramedia', '2008', 43);

-- --------------------------------------------------------

--
-- Table structure for table `kembali`
--

CREATE TABLE `kembali` (
  `id_kembali` varchar(10) NOT NULL,
  `tgl_kembali` date NOT NULL,
  `id_pinjam` varchar(10) NOT NULL,
  `denda` int(11) NOT NULL,
  `id_petugas` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `kembali`
--

INSERT INTO `kembali` (`id_kembali`, `tgl_kembali`, `id_pinjam`, `denda`, `id_petugas`) VALUES
('K001', '2021-02-15', 'PJ035', 0, 'P007'),
('K002', '2021-02-15', 'PJ036', 7000, 'P007'),
('K003', '2021-02-15', 'PJ037', 0, 'P007'),
('K004', '2021-02-15', 'PJ038', 0, 'P007');

-- --------------------------------------------------------

--
-- Table structure for table `petugas`
--

CREATE TABLE `petugas` (
  `id_petugas` varchar(20) NOT NULL,
  `nama_petugas` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `hak_akses` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `petugas`
--

INSERT INTO `petugas` (`id_petugas`, `nama_petugas`, `password`, `hak_akses`) VALUES
('P002', 'pt02', 'pt02', 'petugas'),
('P005', 'abi', 'abi', 'petugas'),
('P006', 'admin', 'admin', 'admin'),
('P007', 'man', 'man', 'admin'),
('P009', 'babe', 'babe', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `pinjam`
--

CREATE TABLE `pinjam` (
  `id_pinjam` varchar(10) NOT NULL,
  `tgl_pinjam` date NOT NULL,
  `tgl_kembali` date DEFAULT NULL,
  `id_buku` varchar(10) NOT NULL,
  `jml_buku` int(11) NOT NULL DEFAULT 1,
  `id_anggota` varchar(20) NOT NULL,
  `id_petugas` varchar(20) NOT NULL,
  `status` varchar(25) NOT NULL DEFAULT 'pinjam'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pinjam`
--

INSERT INTO `pinjam` (`id_pinjam`, `tgl_pinjam`, `tgl_kembali`, `id_buku`, `jml_buku`, `id_anggota`, `id_petugas`, `status`) VALUES
('PJ035', '2021-02-15', '2021-02-22', 'B001', 1, 'A001', 'P007', 'kembali'),
('PJ036', '2021-02-15', '2021-02-08', 'B001', 1, 'A002', 'P007', 'kembali'),
('PJ037', '2021-02-15', '2021-02-22', 'B001', 1, 'A001', 'P007', 'kembali'),
('PJ038', '2021-02-15', '2021-02-22', 'B003', 1, 'A006', 'P007', 'kembali');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `anggota`
--
ALTER TABLE `anggota`
  ADD PRIMARY KEY (`id_anggota`);

--
-- Indexes for table `buku`
--
ALTER TABLE `buku`
  ADD PRIMARY KEY (`id_buku`);

--
-- Indexes for table `kembali`
--
ALTER TABLE `kembali`
  ADD PRIMARY KEY (`id_kembali`);

--
-- Indexes for table `petugas`
--
ALTER TABLE `petugas`
  ADD PRIMARY KEY (`id_petugas`);

--
-- Indexes for table `pinjam`
--
ALTER TABLE `pinjam`
  ADD PRIMARY KEY (`id_pinjam`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
