-- phpMyAdmin SQL Dump
-- version 4.4.11
-- http://www.phpmyadmin.net
--
-- Anamakine: localhost
-- Üretim Zamanı: 08 Mar 2019, 08:12:23
-- Sunucu sürümü: 5.6.25
-- PHP Sürümü: 5.4.43

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `pvpgn`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `pvpgn_bnet`
--

CREATE TABLE IF NOT EXISTS `pvpgn_bnet` (
  `uid` int(11) NOT NULL DEFAULT '0',
  `acct_username` varchar(32) DEFAULT NULL,
  `username` varchar(32) DEFAULT NULL,
  `acct_userid` int(11) DEFAULT NULL,
  `acct_passhash1` varchar(40) DEFAULT NULL,
  `acct_email` varchar(128) DEFAULT NULL,
  `auth_admin` varchar(6) DEFAULT 'false',
  `auth_normallogin` varchar(6) DEFAULT 'true',
  `auth_changepass` varchar(6) DEFAULT 'true',
  `auth_changeprofile` varchar(6) DEFAULT 'true',
  `auth_botlogin` varchar(6) DEFAULT 'false',
  `auth_operator` varchar(6) DEFAULT 'false',
  `new_at_team_flag` int(11) DEFAULT '0',
  `auth_lock` varchar(6) DEFAULT 'false',
  `auth_locktime` int(11) DEFAULT '0',
  `auth_lockreason` varchar(128) DEFAULT NULL,
  `auth_mute` varchar(6) DEFAULT 'false',
  `auth_mutetime` int(11) DEFAULT '0',
  `auth_mutereason` varchar(128) DEFAULT NULL,
  `auth_command_groups` varchar(16) DEFAULT '1',
  `acct_lastlogin_time` int(11) DEFAULT '0',
  `acct_lastlogin_owner` varchar(128) DEFAULT NULL,
  `acct_lastlogin_clienttag` varchar(4) DEFAULT NULL,
  `acct_lastlogin_ip` varchar(16) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `pvpgn_bnet`
--

INSERT INTO `pvpgn_bnet` (`uid`, `acct_username`, `username`, `acct_userid`, `acct_passhash1`, `acct_email`, `auth_admin`, `auth_normallogin`, `auth_changepass`, `auth_changeprofile`, `auth_botlogin`, `auth_operator`, `new_at_team_flag`, `auth_lock`, `auth_locktime`, `auth_lockreason`, `auth_mute`, `auth_mutetime`, `auth_mutereason`, `auth_command_groups`, `acct_lastlogin_time`, `acct_lastlogin_owner`, `acct_lastlogin_clienttag`, `acct_lastlogin_ip`) VALUES
(0, NULL, NULL, NULL, NULL, NULL, 'false', 'true', 'true', 'true', 'false', 'false', 0, 'false', 0, NULL, 'false', 0, NULL, '1', 0, NULL, NULL, NULL),
(1, 'bot1', 'bot1', 1, '3a9fb1381f4a6c0ec1a1f97a74bccea69aac8900', 'a@bot1.com', 'false', 'true', 'true', 'true', 'false', 'false', 0, 'false', 0, NULL, 'false', 0, NULL, '1', 0, NULL, NULL, NULL),
(2, 'bot2', 'bot2', 2, '3a9fb1381f4a6c0ec1a1f97a74bccea69aac8900', 'a@bot2.com', 'false', 'true', 'true', 'true', 'false', 'false', 0, 'false', 0, NULL, 'false', 0, NULL, '1', 0, NULL, NULL, NULL),
(3, 'GProxy', 'GProxy', 3, '3a9fb1381f4a6c0ec1a1f97a74bccea69aac8900', 'a@bot3.com', 'false', 'true', 'true', 'true', 'false', 'false', 0, 'false', 0, NULL, 'false', 0, NULL, '1', 0, NULL, NULL, NULL),
(4, 'dev', 'dev', 4, '3a9fb1381f4a6c0ec1a1f97a74bccea69aac8900', 'a@bot4.com', 'false', 'true', 'true', 'true', 'false', 'false', 0, 'false', 0, NULL, 'false', 0, NULL, '255', 0, NULL, NULL, NULL);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `pvpgn_bnet`
--
ALTER TABLE `pvpgn_bnet`
  ADD PRIMARY KEY (`uid`),
  ADD UNIQUE KEY `username2` (`username`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
