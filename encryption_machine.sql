-- phpMyAdmin SQL Dump
-- version 4.8.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 10 Gru 2018, 04:31
-- Wersja serwera: 10.1.32-MariaDB
-- Wersja PHP: 7.2.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `encryption_machine`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `codes`
--

CREATE TABLE `codes` (
  `id_c` int(11) NOT NULL,
  `code_name` text COLLATE utf8_polish_ci NOT NULL,
  `code_password` text COLLATE utf8_polish_ci NOT NULL,
  `code_admin_password` text COLLATE utf8_polish_ci NOT NULL,
  `charA` text COLLATE utf8_polish_ci NOT NULL,
  `charB` text COLLATE utf8_polish_ci NOT NULL,
  `charC` text COLLATE utf8_polish_ci NOT NULL,
  `charD` text COLLATE utf8_polish_ci NOT NULL,
  `charE` text COLLATE utf8_polish_ci NOT NULL,
  `charF` text COLLATE utf8_polish_ci NOT NULL,
  `charG` text COLLATE utf8_polish_ci NOT NULL,
  `charH` text COLLATE utf8_polish_ci NOT NULL,
  `charI` text COLLATE utf8_polish_ci NOT NULL,
  `charJ` text COLLATE utf8_polish_ci NOT NULL,
  `charK` text COLLATE utf8_polish_ci NOT NULL,
  `charL` text COLLATE utf8_polish_ci NOT NULL,
  `charM` text COLLATE utf8_polish_ci NOT NULL,
  `charN` text COLLATE utf8_polish_ci NOT NULL,
  `charO` text COLLATE utf8_polish_ci NOT NULL,
  `charP` text COLLATE utf8_polish_ci NOT NULL,
  `charQ` text COLLATE utf8_polish_ci NOT NULL,
  `charR` text COLLATE utf8_polish_ci NOT NULL,
  `charS` text COLLATE utf8_polish_ci NOT NULL,
  `charT` text COLLATE utf8_polish_ci NOT NULL,
  `charU` text COLLATE utf8_polish_ci NOT NULL,
  `charV` text COLLATE utf8_polish_ci NOT NULL,
  `charW` text COLLATE utf8_polish_ci NOT NULL,
  `charX` text COLLATE utf8_polish_ci NOT NULL,
  `charY` text COLLATE utf8_polish_ci NOT NULL,
  `charZ` text COLLATE utf8_polish_ci NOT NULL,
  `char1` text COLLATE utf8_polish_ci NOT NULL,
  `char2` text COLLATE utf8_polish_ci NOT NULL,
  `char3` text COLLATE utf8_polish_ci NOT NULL,
  `char4` text COLLATE utf8_polish_ci NOT NULL,
  `char5` text COLLATE utf8_polish_ci NOT NULL,
  `char6` text COLLATE utf8_polish_ci NOT NULL,
  `char7` text COLLATE utf8_polish_ci NOT NULL,
  `char8` text COLLATE utf8_polish_ci NOT NULL,
  `char9` text COLLATE utf8_polish_ci NOT NULL,
  `char0` text COLLATE utf8_polish_ci NOT NULL,
  `charDOT` text COLLATE utf8_polish_ci NOT NULL,
  `charSPACE` text COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `codes`
--

INSERT INTO `codes` (`id_c`, `code_name`, `code_password`, `code_admin_password`, `charA`, `charB`, `charC`, `charD`, `charE`, `charF`, `charG`, `charH`, `charI`, `charJ`, `charK`, `charL`, `charM`, `charN`, `charO`, `charP`, `charQ`, `charR`, `charS`, `charT`, `charU`, `charV`, `charW`, `charX`, `charY`, `charZ`, `char1`, `char2`, `char3`, `char4`, `char5`, `char6`, `char7`, `char8`, `char9`, `char0`, `charDOT`, `charSPACE`) VALUES
(1, 'test', 'test1', 'test2', '1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12', '13', '14', '15', '16', '17', '18', '19', '20', '21', '22', '23', '24', '25', '26', '27', '28', '29', '30', '31', '32', '33', '34', '35', '36', '37', '38');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `codes`
--
ALTER TABLE `codes`
  ADD PRIMARY KEY (`id_c`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `codes`
--
ALTER TABLE `codes`
  MODIFY `id_c` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
