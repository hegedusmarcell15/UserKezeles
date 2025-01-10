SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

CREATE DATABASE IF NOT EXISTS `user` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `user`;

CREATE TABLE `data` (
  `id` int(11) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Password` varchar(36) NOT NULL,
  `CreatedTime` datetime NOT NULL DEFAULT current_timestamp(),
  `UpdatedTime` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `data` (`id`, `FirstName`, `LastName`, `Password`, `CreatedTime`, `UpdatedTime`) VALUES
(1, 'Vladamir', 'Amiable', '199787', '2024-12-20 09:58:42', '2024-12-20 09:58:42'),
(2, 'Gayleen', 'Threadgould', '663278', '2024-12-20 09:58:42', '2024-12-20 09:58:42'),
(3, 'Philipa', 'Kunzler', '695088', '2024-12-20 09:58:42', '2024-12-20 09:58:42'),
(4, 'Garv', 'Alans', '243753', '2024-12-20 09:58:42', '2024-12-20 09:58:42'),
(5, 'Matty', 'Swin', '487044', '2024-12-20 09:58:42', '2024-12-20 09:58:42'),
(6, 'Camile', 'Gyver', '210851', '2024-12-20 09:58:42', '2024-12-20 09:58:42'),
(7, 'Carmel', 'Lassey', '365792', '2024-12-20 09:58:42', '2024-12-20 09:58:42'),
(8, 'Emory', 'Habben', '831219', '2024-12-20 09:58:42', '2024-12-20 09:58:42'),
(9, 'Angie', 'Mattei', '803840', '2024-12-20 09:58:42', '2024-12-20 09:58:42'),
(10, 'Bernhard', 'Lindenbaum', '732749', '2024-12-20 09:58:42', '2024-12-20 09:58:42'),
(11, 'Dolorita', 'Housegoe', '945391', '2024-12-20 09:58:42', '2024-12-20 09:58:42'),
(12, 'Agosto', 'Ryley', '560193', '2024-12-20 09:58:42', '2024-12-20 09:58:42'),
(13, 'Viviyan', 'Drillingcourt', '910354', '2024-12-20 09:58:42', '2024-12-20 09:58:42'),
(14, 'Nicoli', 'Watts', '195238', '2024-12-20 09:58:42', '2024-12-20 09:58:42'),
(15, 'Valle', 'Martyn', '905255', '2024-12-20 09:58:42', '2024-12-20 09:58:42'),
(16, 'La verne', 'Legate', '816654', '2024-12-20 09:58:42', '2024-12-20 09:58:42'),
(17, 'Shurlocke', 'Anstie', '858961', '2024-12-20 09:58:42', '2024-12-20 09:58:42'),
(18, 'April', 'Hewlings', '924763', '2024-12-20 09:58:42', '2024-12-20 09:58:42'),
(19, 'Lynnett', 'Kenrat', '96827', '2024-12-20 09:58:42', '2024-12-20 09:58:42'),
(20, 'Conchita', 'Murcott', '508011', '2024-12-20 09:58:42', '2024-12-20 09:58:42');


ALTER TABLE `data`
  ADD PRIMARY KEY (`id`);


ALTER TABLE `data`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;
