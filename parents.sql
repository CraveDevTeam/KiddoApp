-- phpMyAdmin SQL Dump
-- version 4.9.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 27, 2020 at 12:13 PM
-- Server version: 10.3.16-MariaDB
-- PHP Version: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kiddoapp`
--

-- --------------------------------------------------------

--
-- Table structure for table `parents`
--

CREATE TABLE `parents` (
  `Id` varchar(36) COLLATE utf8_unicode_ci NOT NULL,
  `DadName` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `DadPic_Link` varchar(150) COLLATE utf8_unicode_ci DEFAULT NULL,
  `MumName` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `MumPic_Link` varchar(150) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Email` varchar(30) COLLATE utf8_unicode_ci DEFAULT NULL,
  `created` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `parents`
--

INSERT INTO `parents` (`Id`, `DadName`, `DadPic_Link`, `MumName`, `MumPic_Link`, `Email`, `created`) VALUES
('ajskjsdh65263', 'Jonathan', 'ajskjsdh65263\\Images\\Dad.jpg', 'Alicia', 'ajskjsdh65263\\Images\\Mum.jpg', 'Parents123@home.com', '2020-05-19 16:40:07'),
('bhghye67yel89789aa', 'James Tan', 'bhghye67yel89789aa\\Images\\Dad.jpg', 'Julie Yong', 'bhghye67yel89789aa\\Images\\Mum.jpg', 'ParentsABC@home.com', '2020-05-19 18:13:38'),
('dnjfhwue3493', 'Zaid', 'Images\\dnjfhwue3493\\Dad.jpg', 'Alysha', 'Images\\dnjfhwue3493\\Mum.jpg', 'Zaid@home.com', '2020-05-20 15:24:12'),
('nasidnai32439', 'Cetana', 'Images\\nasidnai32439\\Dad.jpg', 'Somebody', 'Images\\nasidnai32439\\Mum.jpg', 'Cetana@home.com', '2020-05-20 17:33:02'),
('uydtrr78439eg', 'John Ho', 'uydtrr78439eg\\Images\\Dad.jpg', 'Grace Koh', 'uydtrr78439eg\\Images\\Mum.jpg', 'TheHoFamily@Hohome.com', '2020-05-20 10:44:56');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `parents`
--
ALTER TABLE `parents`
  ADD UNIQUE KEY `ParentsID` (`Id`),
  ADD KEY `DadName` (`DadName`),
  ADD KEY `MumName` (`MumName`),
  ADD KEY `created` (`created`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
