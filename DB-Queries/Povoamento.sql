USE MatchWornItems;

-- Insert additional data into Categoria table
INSERT INTO Categoria (Nome)
VALUES
	('T-Shirts'),
	('Sapatilhas'),
	('Camisolas'),
	('Bolas');


INSERT INTO Utilizador (NIB, PrimeiroNome, UltimoNome, Email, NumeroTelemovel, PalavraPasse, Morada)
VALUES 
    (584720193218, 'Francisco', 'Silva', 'francisco.silva@gmail.com', 912345678, 'franciscoSilva', 'Rua das Flores, 123'),
    (109834562890, 'Gabriela', 'Pereira', 'gabriela.pereira@gmail.com', 922345678, '1234fdsa', 'Avenida dos Anjos, 456'),
    (726541809372, 'Henrique', 'Ribeiro', 'henrique.ribeiro@gmail.com', 932456789, 'henriqRib', 'Travessa da Esperan a, 789'),
    (890345617234, 'Ines', 'Santos', 'ines.santos@gmail.com', 913456789, 'SantosInes1234', 'Rua do Castelo, 101'),
    (453287019476, 'Joao', 'Fernandes', 'joao.fernandes@gmail.com', 923567890, 'Palavra4324', 'Largo da Liberdade, 202'),
    (657890341278, 'Katia', 'Martins', 'katia.martins@gmail.com', 933678901, 'SenhaSegura6', 'Pra a da Amizade, 303'),
    (122455789012, 'Luis', 'Oliveira', 'luis.oliveira@gmail.com', 914567890, 'Umapalvrapasse', 'Avenida da Rep blica, 404'),
    (876543210987, 'Miguel', 'Costa', 'miguel.costa@gmail.com', 924678901, 'jose1342', 'Rua do Com rcio, 505'),
    (345678901234, 'Natalia', 'Pinto', 'natalia.pinto@gmail.com', 934789012, 'flores.casa', 'Travessa das Flores, 606'),
    (987654321098, 'Olga', 'Mendes', 'olga.mendes@gmail.com', 915678901, 'olgaMenDes', 'Avenida dos Namorados, 707'),
    (210967654321, 'Ricardo', 'Almeida', 'ricardo.almeida@gmail.com', 925789012, 'teixeiraMota', 'Rua da Esperan a, 808'),
    (876543210947, 'Lara', 'Teixeira', 'lara.teixeira@gmail.com', 926890123, 'luz42', 'Avenida das Estrelas, 909'),
    (543210987654, 'Manuel', 'Cardoso', 'manuel.cardoso@gmail.com', 936901234, 'outracessna', 'Travessa dos Amigos, 1010'),
    (345678901334, 'Noria', 'Goncalves', 'nuria.goncalves@gmail.com', 917012345, 'quemele', 'Largo da Liberdade, 1111'),
    (890123256789, 'Orlando', 'Mota', 'orlando.mota@gmail.com', 927123456, 'ocasoes', 'Pra a da Felicidade, 1212'),
    (567890123451, 'Pedro', 'Rocha', 'pedro.rocha@gmail.com', 937234567, 'quemsoueu', 'Avenida dos Sonhos, 1313'),
    (432109876543, 'Querubim', 'Ferreira', 'querubim.ferreira@gmail.com', 918345678, 'palavrapassesmuitoseguira', 'Rua das Maravilhas, 1414'),
    (987012345678, 'Rafaela', 'Gouveia', 'rafaela.gouveia@gmail.com', 928456789, 'avenidaalegria', 'Avenida da Alegria, 1515'),
    (654321098765, 'Sergio', 'Vieira', 'sergio.vieira@gmail.com', 938567890, 'poetasCamoes', 'Travessa dos Poetas, 1616'),
    (321098765432, 'Tania', 'Baptista', 'tania.baptista@gmail.com', 919678901, 'liverada', 'Pra a da Liberdade, 1717'),
    (890143456789, 'Vitor', 'Lopes', 'vitor.lopes@gmail.com', 929789012, 'artistasLopes', 'Rua dos Artistas, 1818'),
    (567890123456, 'Walter', 'Zagalo', 'walter.zagalo@gmail.com', 939890123, 'WalterEle', 'Avenida das Mar s, 1919'),
    (234567890123, 'Xania', 'Coelho', 'xenia.coelho@gmail.com', 910001122, 'Outrapasse', 'Travessa das Ondas, 2020'),
    (789012545678, 'Yasmin', 'Wu', 'yasmin.wu@gmail.com', 920112233, 'SenhaSegura24', 'Rua do Sol, 2121'),
    (456789012245, 'Zelio', 'Fonseca', 'zelio.fonseca@gmail.com', 930223344, 'NaoDescobremEsta', 'Largo dos Cisnes, 2222'),
    (113456789012, 'Alice', 'Lima', 'alice.lima@gmail.com', 941334455, 'arvoresnaAvenida', 'Avenida das  rvores, 2323'),
    (891122456789, 'Bernardo', 'Z ', 'bernardo.ze@gmail.com', 952445566, 'bernardoZEEEE', 'Travessa dos Rios, 2424'),
    (567890133456, 'Clara', 'Xavier', 'clara.xavier@gmail.com', 963556677, 'clxabier', 'Pra a da Lua, 2525'),
    (214567890123, 'Duarte', 'Vargas', 'duarte.vargas@gmail.com', 974667788, 'vargasdaniel', 'Rua do Mar, 2626'),
    (789012245678, 'Eva', 'Teles', 'eva.teles@gmail.com', 985778899, 'evaTekte', 'Avenida das Estrelas, 2727');




-- Insert additional data into ArtigoLeilao table
INSERT INTO ArtigoLeilao (
    TamanhoArtigo, DataUsoArtigo, NomeEquipaEventoArtigo, NomeArtigo, DescricaoArtigo,
    NumeroAutenticacaoArtigo, EstadoArtigo, ImagemArtigo,
    NomeLeilao, TaxaMinimaIncrementoLeilao, DataFinalizacaoLeilao,
    PrecoCompraAutomaticoLeilao, PrecoBaseLeilao, IdCategoria, IdVendedor, EstadoLeilao
)
VALUES 
    ('M', '2022-12-15', 'Real Madrid', 'Football Kit', 'Match-worn football', 4, 'Usado', 'image_url2',
    'KitRealMadrid', 3.00, '2023-03-01', 80.00, 40.00, 1, 567890123451,'A decorrer'),
    ('S', '2022-11-20', 'Barcelona', 'Shirt', 'Player-used shirt', 5, 'Excellent', 'image_url3',
    'Auction3', 2.00, '2023-04-01', 60.00, 30.00, 2, 234567890123,'A decorrer'),
    ('L', '2023-02-28', 'Manchester United', 'Cap', 'Team cap', 6, 'New', 'image_url4',
    'Auction4', 1.50, '2023-05-01', 30.00, 15.00, 3, 214567890123,'A decorrer'),
    ('XL', '2023-01-10', 'Juventus', 'Jersey', 'Game-worn jersey', 7, 'Good', 'image_url5',
    'Auction5', 4.00, '2023-06-01', 100.00, 50.00, 4, 987654321098,'A decorrer'),
    ('M', '2023-03-05', 'Bayern Munich', 'Football', 'Signed football', 8, 'Used', 'image_url6',
    'Auction6', 3.50, '2023-07-01', 90.00, 45.00, 1, 567890123456,'A decorrer'),
    ('S', '2023-02-15', 'Liverpool', 'Shirt', 'Vintage shirt', 9, 'Fair', 'image_url7',
    'Auction7', 2.50, '2023-08-01', 70.00, 35.00, 2, 567890123451,'A decorrer'),
    ('L', '2023-04-20', 'AC Milan', 'Cap', 'Autographed cap', 10, 'New', 'image_url8',
    'Auction8', 1.75, '2023-09-01', 40.00, 20.00, 3, 345678901234,'A decorrer'),
    ('XL', '2023-05-25', 'Paris Saint-Germain', 'Jersey', 'Limited edition jersey', 11, 'Excellent', 'image_url9',
    'Auction9', 4.50, '2023-10-01', 110.00, 55.00, 3, 214567890123,'A decorrer'),
    ('S', '2023-06-30', 'Chelsea', 'Football', 'Collectors football', 12, 'Like New', 'image_url10',
    'Auction10', 3.75, '2023-11-01', 95.00, 47.50, 4, 345678901234,'A decorrer'),
    ('L', '2023-08-05', 'Borussia Dortmund', 'Shirt', 'Game-issued shirt', 13, 'Good', 'image_url11',
    'Auction11', 2.25, '2023-12-01', 75.00, 37.50, 1, 214567890123,'A decorrer'),
    ('XL', '2023-09-10', 'Inter Milan', 'Cap', 'Team logo cap', 14, 'New', 'image_url12',
    'Auction12', 2.00, '2024-01-01', 50.00, 25.00, 2, 890143456789,'A decorrer'),
    ('S', '2023-10-15', 'Atletico Madrid', 'Jersey', 'Replica jersey', 15, 'Excellent', 'image_url13',
    'Auction13', 5.00, '2024-02-01', 120.00, 60.00, 3, 890143456789,'A decorrer'),
    ('M', '2023-11-20', 'Tottenham Hotspur', 'Football', 'Match-used football', 16, 'Used', 'image_url14',
    'Auction14', 4.25, '2024-03-01', 105.00, 52.50, 4, 567890123451,'A decorrer'),
    ('S', '2024-01-25', 'Manchester City', 'Shirt', 'Autographed shirt', 17, 'Good', 'image_url15',
    'Auction15', 2.75, '2024-04-01', 65.00, 32.50, 1, 109834562890,'A decorrer'),
    ('L', '2024-02-28', 'Arsenal', 'Cap', 'Players cap', 18, 'Used', 'image_url16',
    'Auction16', 1.90, '2024-05-01', 35.00, 17.50, 2, 109834562890,'A decorrer'),
    ('M', '2024-04-05', 'Real Betis', 'Jersey', 'Team-signed jersey', 19, 'Excellent', 'image_url17',
    'Auction17', 4.75, '2024-06-01', 115.00, 57.50, 3, 987012345678,'A decorrer'),
    ('XL', '2024-05-10', 'AS Roma', 'Football', 'Limited edition football', 20, 'Like New', 'image_url18',
    'Auction18', 3.25, '2024-07-01', 85.00, 42.50, 2, 987012345678,'A decorrer'),
    ('S', '2024-06-15', 'Napoli', 'Shirt', 'Game-worn shirt', 21, 'Fair', 'image_url19',
    'Auction19', 2.00, '2024-08-01', 55.00, 27.50, 1, 987012345678,'A decorrer'),
    ('L', '2024-07-20', 'Sevilla', 'Cap', 'Vintage cap', 22, 'New', 'image_url20',
    'Auction20', 2.15, '2024-09-01', 45.00, 22.50, 1, 891122456789,'A decorrer'),
    ('M', '2024-08-25', 'Valencia', 'Jersey', 'Player-autographed jersey', 23, 'Excellent', 'image_url21',
    'Auction21', 5.25, '2024-10-01', 125.00, 62.50, 2, 567890123451,'A decorrer'),
    ('XL', '2024-09-30', 'Villarreal', 'Football', 'Replica football', 24, 'Good', 'image_url22',
    'Auction22', 3.50, '2024-11-01', 95.00, 47.50, 3, 584720193218,'A decorrer'),
    ('S', '2024-11-05', 'Celta Vigo', 'Shirt', 'Team-logo shirt', 25, 'New', 'image_url23',
    'Auction23', 2.25, '2024-12-01', 70.00, 35.00, 3, 891122456789,'A decorrer'),
    ('L', '2024-12-10', 'Espanyol', 'Cap', 'Autographed team cap', 26, 'Excellent', 'image_url24',
    'Auction24', 2.10, '2025-01-01', 50.00, 25.00, 4, 584720193218,'A decorrer');




-- Insert additional data into Licitacao table
INSERT INTO Licitacao (ValorLicitacao, NIBComprador, IdLeilao)
VALUES 
    (70.00, 584720193218, 1),
    (45.00, 891122456789, 2),
    (25.00, 987654321098, 3),
    (100.00, 987654321098, 3),
    (65.00, 584720193218, 5),
    (40.00, 987654321098, 6);
  
