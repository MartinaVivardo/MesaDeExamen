-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: localhost    Database: mesasdeexamenes
-- ------------------------------------------------------
-- Server version	8.0.39

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `carreras`
--

DROP TABLE IF EXISTS `carreras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `carreras` (
  `IdCarrera` int NOT NULL AUTO_INCREMENT,
  `NombreCarrera` varchar(50) DEFAULT NULL,
  `Duracion` int DEFAULT NULL,
  PRIMARY KEY (`IdCarrera`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carreras`
--

LOCK TABLES `carreras` WRITE;
/*!40000 ALTER TABLE `carreras` DISABLE KEYS */;
INSERT INTO `carreras` VALUES (1,'Analista de Sitemas',3),(2,'Psicopedagogia',4),(3,'Maestra jardinera',4),(5,'hola',6);
/*!40000 ALTER TABLE `carreras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detallemesadeexamen`
--

DROP TABLE IF EXISTS `detallemesadeexamen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detallemesadeexamen` (
  `IdDetalle` int NOT NULL AUTO_INCREMENT,
  `IdMesa` int DEFAULT NULL,
  `IdEstudiante` int DEFAULT NULL,
  `Presente` tinyint DEFAULT NULL,
  `NotaFinal` int DEFAULT NULL,
  PRIMARY KEY (`IdDetalle`),
  KEY `FK_DetalleMesaDeExamen_MesaExamen_idx` (`IdMesa`),
  KEY `FK_DetalleMesaDeExamen_Estudiantes_idx` (`IdEstudiante`),
  CONSTRAINT `FK_DetalleMesaDeExamen_Estudiantes` FOREIGN KEY (`IdEstudiante`) REFERENCES `estudiantes` (`idEstudiante`),
  CONSTRAINT `FK_DetalleMesaDeExamen_MesaExamen` FOREIGN KEY (`IdMesa`) REFERENCES `mesaexamen` (`IdMesaExamen`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallemesadeexamen`
--

LOCK TABLES `detallemesadeexamen` WRITE;
/*!40000 ALTER TABLE `detallemesadeexamen` DISABLE KEYS */;
/*!40000 ALTER TABLE `detallemesadeexamen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estudiantes`
--

DROP TABLE IF EXISTS `estudiantes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estudiantes` (
  `idEstudiante` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) DEFAULT NULL,
  `Apellido` varchar(50) DEFAULT NULL,
  `TipoDoc` varchar(20) DEFAULT NULL,
  `Documento` varchar(10) DEFAULT NULL,
  `IdCarrera` int DEFAULT NULL,
  `NroMatricula` int DEFAULT NULL,
  PRIMARY KEY (`idEstudiante`),
  KEY `FK_Estudiantes_Carreras_idx` (`IdCarrera`),
  CONSTRAINT `FK_Estudiantes_Carreras` FOREIGN KEY (`IdCarrera`) REFERENCES `carreras` (`IdCarrera`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estudiantes`
--

LOCK TABLES `estudiantes` WRITE;
/*!40000 ALTER TABLE `estudiantes` DISABLE KEYS */;
INSERT INTO `estudiantes` VALUES (1,'sdcsdf','adada','46262520','dni',2,1);
/*!40000 ALTER TABLE `estudiantes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `llamados`
--

DROP TABLE IF EXISTS `llamados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `llamados` (
  `IdLlamado` int NOT NULL AUTO_INCREMENT,
  `Mes` int DEFAULT NULL,
  `Año` int DEFAULT NULL,
  `Numero` int DEFAULT NULL,
  `Activo` tinyint DEFAULT NULL,
  PRIMARY KEY (`IdLlamado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `llamados`
--

LOCK TABLES `llamados` WRITE;
/*!40000 ALTER TABLE `llamados` DISABLE KEYS */;
/*!40000 ALTER TABLE `llamados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `materias`
--

DROP TABLE IF EXISTS `materias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `materias` (
  `IdMateria` int NOT NULL AUTO_INCREMENT,
  `NombreMateria` varchar(50) DEFAULT NULL,
  `IdProfesor` int DEFAULT NULL,
  `IdCarerra` int DEFAULT NULL,
  `Año` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`IdMateria`),
  KEY `FK_Profesores_Materias_idx` (`IdProfesor`),
  KEY `FK_Materias_Carreras_idx` (`IdCarerra`),
  CONSTRAINT `FK_Materias_Carreras` FOREIGN KEY (`IdCarerra`) REFERENCES `carreras` (`IdCarrera`),
  CONSTRAINT `FK_Profesores_Materias` FOREIGN KEY (`IdProfesor`) REFERENCES `profesores` (`IdProfesor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `materias`
--

LOCK TABLES `materias` WRITE;
/*!40000 ALTER TABLE `materias` DISABLE KEYS */;
/*!40000 ALTER TABLE `materias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mesaexamen`
--

DROP TABLE IF EXISTS `mesaexamen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mesaexamen` (
  `IdMesaExamen` int NOT NULL AUTO_INCREMENT,
  `IdMateria` int DEFAULT NULL,
  `Fecha` datetime DEFAULT NULL,
  `ProfesorVocal` int DEFAULT NULL,
  `IdLlamado` int DEFAULT NULL,
  `Finalizada` tinyint DEFAULT NULL,
  PRIMARY KEY (`IdMesaExamen`),
  KEY `FK_MesaExamen_Materia_idx` (`IdMateria`),
  KEY `FK_MesaExamen_Profesores_idx` (`ProfesorVocal`),
  KEY `FK_MesaExamen_Llamados_idx` (`IdLlamado`),
  CONSTRAINT `FK_MesaExamen_Llamados` FOREIGN KEY (`IdLlamado`) REFERENCES `llamados` (`IdLlamado`),
  CONSTRAINT `FK_MesaExamen_Materias` FOREIGN KEY (`IdMateria`) REFERENCES `materias` (`IdMateria`),
  CONSTRAINT `FK_MesaExamen_Profesores` FOREIGN KEY (`ProfesorVocal`) REFERENCES `profesores` (`IdProfesor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mesaexamen`
--

LOCK TABLES `mesaexamen` WRITE;
/*!40000 ALTER TABLE `mesaexamen` DISABLE KEYS */;
/*!40000 ALTER TABLE `mesaexamen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `profesores`
--

DROP TABLE IF EXISTS `profesores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `profesores` (
  `IdProfesor` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) DEFAULT NULL,
  `Apellido` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`IdProfesor`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `profesores`
--

LOCK TABLES `profesores` WRITE;
/*!40000 ALTER TABLE `profesores` DISABLE KEYS */;
INSERT INTO `profesores` VALUES (1,'Miguel','Caram'),(2,'Leandro','Masotti'),(3,'Pablo','Lazzaro');
/*!40000 ALTER TABLE `profesores` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-09-18 19:04:28
