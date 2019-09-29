-- phpMyAdmin SQL Dump
-- version 4.0.4.2
-- http://www.phpmyadmin.net
--
-- Machine: localhost
-- Genereertijd: 16 aug 2018 om 21:44
-- Serverversie: 5.6.13
-- PHP-versie: 5.4.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Databank: `auth`
--
CREATE DATABASE IF NOT EXISTS `auth` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `auth`;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `accounts`
--

CREATE TABLE IF NOT EXISTS `accounts` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(40) CHARACTER SET utf8 NOT NULL,
  `Nickname` varchar(40) CHARACTER SET utf8 DEFAULT NULL,
  `Password` varchar(40) CHARACTER SET utf8 DEFAULT NULL,
  `Salt` varchar(40) CHARACTER SET utf8 DEFAULT NULL,
  `SecurityLevel` tinyint(3) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Username` (`Username`),
  UNIQUE KEY `Nickname` (`Nickname`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Gegevens worden uitgevoerd voor tabel `accounts`
--

INSERT INTO `accounts` (`Id`, `Username`, `Nickname`, `Password`, `Salt`, `SecurityLevel`) VALUES
(2, 'Zandrox', 'Faceless', 'x+2GHYievyvEI4zphqqXfpsCPIgcmYxZ', 'GlsiEMOjqturkqarjjjvRi/HiuvYy/2O', 0),
(3, 'test', 'test', 'M6b1cIBjjhL5VwfuJnidTAT0D8mN5cNc', 'iyCYlaJvdEe105V2d1FrK34LOx58uDJm', 0),
(4, 'test1', NULL, NULL, NULL, 0);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `bans`
--

CREATE TABLE IF NOT EXISTS `bans` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `AccountId` int(11) NOT NULL,
  `Date` bigint(20) NOT NULL DEFAULT '0',
  `Duration` bigint(20) DEFAULT NULL,
  `Reason` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `AccountId` (`AccountId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `login_history`
--

CREATE TABLE IF NOT EXISTS `login_history` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `AccountId` int(11) NOT NULL,
  `Date` bigint(20) NOT NULL DEFAULT '0',
  `IP` varchar(15) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `AccountId` (`AccountId`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=89 ;

--
-- Gegevens worden uitgevoerd voor tabel `login_history`
--

INSERT INTO `login_history` (`Id`, `AccountId`, `Date`, `IP`) VALUES
(1, 2, 1530804677, '127.0.0.1'),
(2, 2, 1530805015, '127.0.0.1'),
(3, 3, 1530807192, '127.0.0.1'),
(4, 3, 1530807276, '127.0.0.1'),
(5, 3, 1530807698, '127.0.0.1'),
(6, 3, 1530808108, '127.0.0.1'),
(7, 3, 1530824818, '127.0.0.1'),
(8, 3, 1530827424, '127.0.0.1'),
(9, 3, 1530827505, '127.0.0.1'),
(10, 3, 1530828055, '127.0.0.1'),
(11, 3, 1530828623, '127.0.0.1'),
(12, 3, 1530829380, '127.0.0.1'),
(13, 3, 1533219407, '127.0.0.1'),
(14, 3, 1533219540, '127.0.0.1'),
(15, 3, 1533220707, '127.0.0.1'),
(16, 3, 1533224555, '127.0.0.1'),
(17, 3, 1533227301, '127.0.0.1'),
(18, 3, 1533235821, '127.0.0.1'),
(19, 3, 1533388393, '127.0.0.1'),
(20, 3, 1533391267, '127.0.0.1'),
(21, 3, 1533458186, '127.0.0.1'),
(22, 3, 1533459361, '127.0.0.1'),
(23, 3, 1533459761, '127.0.0.1'),
(24, 3, 1533460202, '127.0.0.1'),
(25, 3, 1533460307, '127.0.0.1'),
(26, 3, 1533461144, '127.0.0.1'),
(27, 3, 1533461933, '127.0.0.1'),
(28, 3, 1533462155, '127.0.0.1'),
(29, 3, 1533462315, '127.0.0.1'),
(30, 3, 1533462355, '127.0.0.1'),
(31, 3, 1533462445, '127.0.0.1'),
(32, 3, 1533462545, '127.0.0.1'),
(33, 3, 1533462654, '127.0.0.1'),
(34, 3, 1533462760, '127.0.0.1'),
(35, 3, 1533463520, '127.0.0.1'),
(36, 3, 1533463611, '127.0.0.1'),
(37, 3, 1533463694, '127.0.0.1'),
(38, 3, 1533463793, '127.0.0.1'),
(39, 3, 1533463871, '127.0.0.1'),
(40, 3, 1533463983, '127.0.0.1'),
(41, 3, 1533464042, '127.0.0.1'),
(42, 3, 1533464151, '127.0.0.1'),
(43, 3, 1533464224, '127.0.0.1'),
(44, 3, 1533464287, '127.0.0.1'),
(45, 3, 1533464374, '127.0.0.1'),
(46, 3, 1533464475, '127.0.0.1'),
(47, 3, 1533464606, '127.0.0.1'),
(48, 3, 1533465729, '127.0.0.1'),
(49, 3, 1533466148, '127.0.0.1'),
(50, 3, 1533466508, '127.0.0.1'),
(51, 3, 1533466556, '127.0.0.1'),
(52, 3, 1533466663, '127.0.0.1'),
(53, 3, 1533466760, '127.0.0.1'),
(54, 3, 1533466799, '127.0.0.1'),
(55, 3, 1533466885, '127.0.0.1'),
(56, 3, 1533467721, '127.0.0.1'),
(57, 3, 1533471925, '127.0.0.1'),
(58, 3, 1533472195, '127.0.0.1'),
(59, 3, 1533472386, '127.0.0.1'),
(60, 3, 1533473039, '127.0.0.1'),
(61, 3, 1533473082, '127.0.0.1'),
(62, 3, 1533473266, '127.0.0.1'),
(63, 3, 1533473475, '127.0.0.1'),
(64, 3, 1533839717, '127.0.0.1'),
(65, 3, 1533839824, '127.0.0.1'),
(66, 3, 1533839893, '127.0.0.1'),
(67, 3, 1534164473, '127.0.0.1'),
(68, 3, 1534164861, '127.0.0.1'),
(69, 3, 1534165213, '127.0.0.1'),
(70, 3, 1534165570, '127.0.0.1'),
(71, 3, 1534166149, '127.0.0.1'),
(72, 3, 1534166275, '127.0.0.1'),
(73, 3, 1534166970, '127.0.0.1'),
(74, 3, 1534168471, '127.0.0.1'),
(75, 3, 1534173519, '127.0.0.1'),
(76, 3, 1534174846, '127.0.0.1'),
(77, 3, 1534175916, '127.0.0.1'),
(78, 3, 1534176040, '127.0.0.1'),
(79, 3, 1534176977, '127.0.0.1'),
(80, 3, 1534177013, '127.0.0.1'),
(81, 3, 1534177391, '127.0.0.1'),
(82, 3, 1534177752, '127.0.0.1'),
(83, 3, 1534178157, '127.0.0.1'),
(84, 3, 1534182804, '127.0.0.1'),
(85, 3, 1534182871, '127.0.0.1'),
(86, 3, 1534183153, '127.0.0.1'),
(87, 3, 1534183260, '127.0.0.1'),
(88, 3, 1534183833, '127.0.0.1');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `nickname_history`
--

CREATE TABLE IF NOT EXISTS `nickname_history` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `AccountId` int(11) NOT NULL,
  `Nickname` varchar(40) CHARACTER SET utf8 NOT NULL,
  `ExpireDate` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `AccountId` (`AccountId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `__version`
--

CREATE TABLE IF NOT EXISTS `__version` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Version` bigint(20) NOT NULL,
  `AppliedOn` datetime NOT NULL,
  `Description` text NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Gegevens worden uitgevoerd voor tabel `__version`
--

INSERT INTO `__version` (`Id`, `Version`, `AppliedOn`, `Description`) VALUES
(1, 1, '2018-07-04 02:56:13', 'Base');

--
-- Beperkingen voor gedumpte tabellen
--

--
-- Beperkingen voor tabel `bans`
--
ALTER TABLE `bans`
  ADD CONSTRAINT `bans_ibfk_1` FOREIGN KEY (`AccountId`) REFERENCES `accounts` (`Id`) ON DELETE CASCADE;

--
-- Beperkingen voor tabel `login_history`
--
ALTER TABLE `login_history`
  ADD CONSTRAINT `login_history_ibfk_1` FOREIGN KEY (`AccountId`) REFERENCES `accounts` (`Id`) ON DELETE CASCADE;

--
-- Beperkingen voor tabel `nickname_history`
--
ALTER TABLE `nickname_history`
  ADD CONSTRAINT `nickname_history_ibfk_1` FOREIGN KEY (`AccountId`) REFERENCES `accounts` (`Id`) ON DELETE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
