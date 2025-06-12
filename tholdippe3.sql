-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : sam. 07 juin 2025 à 18:19
-- Version du serveur : 10.4.32-MariaDB
-- Version de PHP : 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `tholdippe3`
--

-- --------------------------------------------------------

--
-- Structure de la table `container`
--

CREATE TABLE `container` (
  `NUMCONTAINER` int(11) NOT NULL,
  `DATEACHAT` datetime NOT NULL,
  `TYPECONTAINER` varchar(40) NOT NULL,
  `DATELIMITEPROCHINSP` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `container`
--

INSERT INTO `container` (`NUMCONTAINER`, `DATEACHAT`, `TYPECONTAINER`, `DATELIMITEPROCHINSP`) VALUES
(1, '2017-11-22 00:00:00', 'tech', '2017-11-24 00:00:00'),
(2, '2017-11-30 00:00:00', 'notech', '2017-12-20 00:00:00');

-- --------------------------------------------------------

--
-- Structure de la table `decision`
--

CREATE TABLE `decision` (
  `NUMCONTAINER` int(11) NOT NULL,
  `NUMINSPECTION` int(11) NOT NULL,
  `CODETRAVAUX` int(11) NOT NULL,
  `DATEENVOI` datetime NOT NULL,
  `DATERETOUR` datetime NOT NULL,
  `COMMENTAIRE` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `declaration`
--

CREATE TABLE `declaration` (
  `CODEDECLARATION` int(11) NOT NULL,
  `NUMCONTAINER` int(11) NOT NULL,
  `LIBELLEPROBLEME` varchar(40) NOT NULL,
  `COMMENTAIRE` varchar(100) NOT NULL,
  `DATEDECLARATION` datetime NOT NULL,
  `URGENCE` tinyint(1) NOT NULL,
  `TRAITE` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `declaration`
--

INSERT INTO `declaration` (`CODEDECLARATION`, `NUMCONTAINER`, `LIBELLEPROBLEME`, `COMMENTAIRE`, `DATEDECLARATION`, `URGENCE`, `TRAITE`) VALUES
(1, 2, 'Recyclage', 'container mort', '2025-03-25 00:00:00', 0, 0),
(2, 2, 'Autre', 'container moisi', '2025-03-13 00:00:00', 0, 0),
(3, 1, 'Probleme', 'container percé', '2025-03-31 00:00:00', 1, 0),
(4, 1, 'Visite annuelle', 'contrôle', '2025-05-06 00:00:00', 1, 0);

-- --------------------------------------------------------

--
-- Structure de la table `inspection`
--

CREATE TABLE `inspection` (
  `NUMINSPECTION` int(11) NOT NULL,
  `NUMCONTAINER` int(11) NOT NULL,
  `LIBELLEMOTIF` varchar(40) NOT NULL,
  `LIBELLEETAT` varchar(40) NOT NULL,
  `DATEINSPECTION` datetime NOT NULL,
  `COMMENTAIREPOSTINSPECTION` varchar(100) NOT NULL,
  `AVIS` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `inspection`
--

INSERT INTO `inspection` (`NUMINSPECTION`, `NUMCONTAINER`, `LIBELLEMOTIF`, `LIBELLEETAT`, `DATEINSPECTION`, `COMMENTAIREPOSTINSPECTION`, `AVIS`) VALUES
(1, 1, 'Probleme', 'Finie', '2025-03-27 00:00:00', 'a voir', 'a voir'),
(2, 2, 'Recyclage', 'En cours', '2025-03-27 00:00:00', 'Container HS - doit être détruit', 'Container HS - doit être détru'),
(3, 2, '', '', '2025-03-27 00:00:00', '', ''),
(4, 2, 'Visite annuelle', 'Finie', '2025-03-29 00:00:00', 'tout OK', 'tout OK'),
(5, 1, 'Autre', 'Prevue', '2025-04-01 00:00:00', 'dfefed', 'dfefed');

-- --------------------------------------------------------

--
-- Structure de la table `probleme`
--

CREATE TABLE `probleme` (
  `CODEPROBLEME` int(11) NOT NULL,
  `LIBELLEPROBLEME` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `probleme`
--

INSERT INTO `probleme` (`CODEPROBLEME`, `LIBELLEPROBLEME`) VALUES
(1, 'Corrosion'),
(2, 'Choc sur container'),
(3, 'Gong défectueux'),
(4, 'Pb réfrigération'),
(5, 'Autre');

-- --------------------------------------------------------

--
-- Structure de la table `travaux`
--

CREATE TABLE `travaux` (
  `CODETRAVAUX` int(11) NOT NULL,
  `LIBELLETRAVAUX` varchar(40) NOT NULL,
  `DUREEIMMOBILISATION` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `id` int(11) NOT NULL,
  `nom_utilisateur` varchar(50) NOT NULL,
  `mot_de_passe` varchar(255) DEFAULT NULL,
  `role` enum('docker','chefEquipe','admin') NOT NULL DEFAULT 'docker'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`id`, `nom_utilisateur`, `mot_de_passe`, `role`) VALUES
(1, 'docker', '$2a$08$lAQ6zbl0Xhpy1P5Ra0GWjOgI0jTYoP5wOM8H1cHRVkyG4evPo11CK', 'docker'),
(2, 'chefEquipe', '$2a$08$UfgamRFVeGjiMU7ZQBVmr.05e8r9t0VROI8f6wgdEHbY1mbysf2fq', 'chefEquipe');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `container`
--
ALTER TABLE `container`
  ADD PRIMARY KEY (`NUMCONTAINER`);

--
-- Index pour la table `decision`
--
ALTER TABLE `decision`
  ADD PRIMARY KEY (`NUMCONTAINER`,`NUMINSPECTION`),
  ADD KEY `NUMINSPECTION` (`NUMINSPECTION`),
  ADD KEY `CODETRAVAUX` (`CODETRAVAUX`);

--
-- Index pour la table `declaration`
--
ALTER TABLE `declaration`
  ADD PRIMARY KEY (`CODEDECLARATION`),
  ADD KEY `NUMCONTAINER` (`NUMCONTAINER`);

--
-- Index pour la table `inspection`
--
ALTER TABLE `inspection`
  ADD PRIMARY KEY (`NUMINSPECTION`),
  ADD KEY `NUMCONTAINER` (`NUMCONTAINER`);

--
-- Index pour la table `probleme`
--
ALTER TABLE `probleme`
  ADD PRIMARY KEY (`CODEPROBLEME`);

--
-- Index pour la table `travaux`
--
ALTER TABLE `travaux`
  ADD PRIMARY KEY (`CODETRAVAUX`);

--
-- Index pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nom_utilisateur` (`nom_utilisateur`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `container`
--
ALTER TABLE `container`
  MODIFY `NUMCONTAINER` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `declaration`
--
ALTER TABLE `declaration`
  MODIFY `CODEDECLARATION` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `inspection`
--
ALTER TABLE `inspection`
  MODIFY `NUMINSPECTION` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT pour la table `probleme`
--
ALTER TABLE `probleme`
  MODIFY `CODEPROBLEME` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT pour la table `travaux`
--
ALTER TABLE `travaux`
  MODIFY `CODETRAVAUX` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `decision`
--
ALTER TABLE `decision`
  ADD CONSTRAINT `decision_ibfk_1` FOREIGN KEY (`NUMCONTAINER`) REFERENCES `container` (`NUMCONTAINER`) ON DELETE CASCADE,
  ADD CONSTRAINT `decision_ibfk_2` FOREIGN KEY (`NUMINSPECTION`) REFERENCES `inspection` (`NUMINSPECTION`) ON DELETE CASCADE,
  ADD CONSTRAINT `decision_ibfk_3` FOREIGN KEY (`CODETRAVAUX`) REFERENCES `travaux` (`CODETRAVAUX`) ON DELETE CASCADE;

--
-- Contraintes pour la table `declaration`
--
ALTER TABLE `declaration`
  ADD CONSTRAINT `declaration_ibfk_1` FOREIGN KEY (`NUMCONTAINER`) REFERENCES `container` (`NUMCONTAINER`) ON DELETE CASCADE;

--
-- Contraintes pour la table `inspection`
--
ALTER TABLE `inspection`
  ADD CONSTRAINT `inspection_ibfk_1` FOREIGN KEY (`NUMCONTAINER`) REFERENCES `container` (`NUMCONTAINER`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
