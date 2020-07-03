CREATE TABLE matakuliah(
kode_matkul char(6) primary key,
nama_matkul varchar(75),
sks int,
semester int, 
kode_prodi varchar(6))

SELECT * FROM prodi;
DROP TABLE matakuliah;

INSERT INTO matakuliah VALUES('061001', 
'Algoritma dan Pemograman I', 3, 1, 'IF');
INSERT INTO matakuliah VALUES('061002', 
'Matematika Kalkulus', 3, 1, 'IF');
INSERT INTO matakuliah VALUES('061003', 
'General English', 2, 1, 'IF');
INSERT INTO matakuliah VALUES('063001', 
'Pemograman III (Visual)', 3, 3, 'IF');
INSERT INTO matakuliah VALUES('063002', 
'Metode Numerik', 3, 3, 'IF');
INSERT INTO matakuliah VALUES('063003', 
'Struktur Data', 3, 3, 'IF');
INSERT INTO matakuliah VALUES('011001', 
'Algoritma', 3, 1, 'SI');
INSERT INTO matakuliah VALUES('011002', 
'General English', 3, 1, 'SI');
INSERT INTO matakuliah VALUES('011003', 
'Pengantar teknologi Informasi', 3, 1, 'SI');
INSERT INTO matakuliah VALUES('013001', 
'Sistem Basis Data', 3, 3, 'SI');

SELECT * FROM matakuliah;

SELECT kode_matkul, nama_matkul, sks FROM matakuliah
WHERE semester=3 AND kode_prodi='IF';

CREATE TABLE head_frs(
kode_frs int primary key,
tahun_akademik varchar(10),
semester int,
npm char(10),
kode_prodi varchar(6))

DROP TABLE head_frs;

CREATE TABLE detail_frs(
kode_frs int,
kode_matkul char(6))

SELECT * FROM head_frs;
SELECT * FROM detail_frs;

DELETE FROM head_frs;
DELETE FROM detail_frs;

SELECT kode_matkul, nama_matkul, sks FROM matakuliah
WHERE semester=1 AND kode_prodi='IF' AND kode_matkul
NOT IN (SELECT m.kode_matkul FROM matakuliah m
JOIN detail_frs df ON (m.kode_matkul = df.kode_matkul)
JOIN head_frs hf ON (hf.kode_frs = df.kode_frs)
WHERE m.semester=1 AND m.kode_prodi='IF' AND hf.npm='1020304050');

