-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Время создания: Авг 15 2019 г., 00:42
-- Версия сервера: 5.5.25
-- Версия PHP: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `lesson`
--

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `login` varchar(50) NOT NULL DEFAULT 'empty',
  `password` varchar(50) NOT NULL DEFAULT 'empty',
  `name` varchar(25) NOT NULL DEFAULT 'empty',
  `address` varchar(50) NOT NULL DEFAULT 'empty',
  `age` int(11) DEFAULT '0',
  `sex` varchar(15) NOT NULL DEFAULT 'empty',
  PRIMARY KEY (`login`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`login`, `password`, `name`, `address`, `age`, `sex`) VALUES
('user1@g.com', 'T61n8hIysgoCPtP8jBc6vA==', 'vlad', 'kyiv', 20, 'male'),
('user2@g.com', 'gvkV9Hfe7cD3B2oScsB5Wg==', 'dasha', 'kyiv', 26, 'female');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
