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



INSERT INTO ArtigoLeilao (
    TamanhoArtigo, DataUsoArtigo, NomeEquipaEventoArtigo, NomeArtigo, DescricaoArtigo,
    NumeroAutenticacaoArtigo, EstadoArtigo, ImagemArtigo,
    NomeLeilao, TaxaMinimaIncrementoLeilao, DataFinalizacaoLeilao,
    PrecoCompraAutomaticoLeilao, PrecoBaseLeilao, IdCategoria, IdVendedor, EstadoLeilao
) VALUES
    ('M', '2022-12-15', 'AC Milan', 'Football Kit', 'Match-worn Balotelli shirt',
     '4', 'Usado', 'Auction1', 'Balotelli ACMilan', 3.00, '2024-01-15',
     80.00, 40.00, 1, '567890123451', 'A decorrer'),
    ('S', '2022-11-20', 'New England Patriots', 'Shirt', 'Brady-used shirt',
     '5', 'Excellent', 'Auction2', 'Brady shirt from Patriots', 2.00, '2024-01-15',
     60.00, 30.00, 1, '234567890123', 'A decorrer'),
    ('L', '2023-02-28', 'Manchester United', 'Shirt', 'Captain Fernandes used shirt',
     '6', 'New', 'Auction3', 'Bruno Fernandes used shirt from United', 1.50, '2024-01-15',
     30.00, 15.00, 1, '214567890123', 'A decorrer'),
    ('XL', '2023-01-10', 'PSG', 'Jersey', 'Icardi used shirt from PSG',
     '7', 'Good', 'Auction4', 'Mauro Icardi used shirt', 4.00, '2024-01-15',
     100.00, 50.00, 1, '987654321098', 'A decorrer'),
    ('M', '2023-03-05', 'SportingCP', 'Jersey', 'Vintage shirt from Cristiano Ronaldo',
     '8', 'Used', 'Auction5', 'Vintage Ronaldo shirt from former club', 3.50, '2024-01-15',
     90.00, 45.00, 1, '567890123456', 'A decorrer'),
    ('S', '2023-02-15', 'LA Lakers', 'Shirt', 'Vintage shirt',
     '9', 'Fair', 'Auction6', 'LA Lakers jersey from the GOAT', 2.50, '2024-01-15',
     70.00, 35.00, 1, '567890123451', 'A decorrer'),
    ('L', '2023-04-20', 'NFL', 'Ball', 'Official game ball',
     '10', 'New', 'iAuction7', 'Ball used in NFL', 1.75, '2024-01-15',
     40.00, 20.00, 2, '345678901234', 'A decorrer'),
    ('XL', '2023-05-25', 'Manchester United', 'Jersey', 'Pogba used jersey for Man United',
     '11', 'Excellent', 'Auction8', 'Paul Pogba black jersey used', 4.50, '2024-01-15',
     110.00, 55.00, 1, '214567890123', 'A decorrer'),
    ('S', '2023-06-30', 'Nadal', 'Racket Nadal', 'Racket that was used by Nadal',
     '12', 'Like New', 'Auction9', 'Nadal used racket', 3.75, '2024-01-15',
     95.00, 47.50, 3, '345678901234', 'A decorrer'),
    ('L', '2023-08-05', 'AC Milan', 'Ronaldinho shirt', 'Game-used shirt',
     '13', 'Good', 'Auction10', 'Ronaldinho Milan jersey', 2.25, '2024-01-15',
     75.00, 37.50, 1, '214567890123', 'A decorrer'),
    ('XL', '2023-09-10', 'Al Nassr', 'Ronaldo used match jersey', 'Match used jersey',
     '14', 'New', 'Auction11', 'CR7 Al Nassr jersey 2023', 2.00, '2024-01-15',
     50.00, 25.00, 1, '890143456789', 'A decorrer'),
    ('S', '2023-10-15', 'RB Leipzig', 'Jersey Timo Werner', 'Match used jersey',
     '15', 'Excellent', 'Auction12', 'Timo Werner shirt Leipzig', 5.00, '2024-01-15',
     120.00, 60.00, 1, '890143456789', 'A decorrer'),
    ('M', '2023-11-20', 'LA Lakers', 'Lebron James shirt', 'Match-used shirt',
     '16', 'Used', 'Auction13', 'LJames used jersey LA', 4.25, '2024-01-15',
    105.00, 52.50, 1, '567890123451', 'A decorrer'),
    ('S', '2023-11-21', 'Manchester City', 'Shirt', 'Autographed shirt',
    '17', 'Good', 'Auction14', 'Auction15', 2.75, '2024-01-15',
    65.00, 32.50, 1, '109834562890', 'A decorrer'),
    ('L', '2023-11-21', 'Arsenal', 'Cap', 'Players cap',
    '18', 'Used', 'Auction15', 'Auction16', 1.90, '2024-01-15',
    35.00, 17.50, 2, '109834562890', 'A decorrer'),
    ('M', '2023-11-21', 'Real Betis', 'Jersey', 'Team-signed jersey',
    '19', 'Excellent', 'Auction16', 'Auction17', 4.75, '2024-01-15',
    115.00, 57.50, 3, '987012345678', 'A decorrer'),
    ('XL', '2023-11-22', 'AS Roma', 'Football', 'Limited edition football',
    '20', 'Like New', 'Auction17', 'Auction18', 3.25, '2024-01-15',
    85.00, 42.50, 2, '987012345678', 'A decorrer'),
    ('S', '2023-11-22', 'Napoli', 'Shirt', 'Game-worn shirt',
    '21', 'Fair', 'Auction18', 'Auction19', 2.00, '2024-01-15',
    55.00, 27.50, 1, '987012345678', 'A decorrer'),
    ('L', '2023-11-22', 'Sevilla', 'Cap', 'Vintage cap',
    '22', 'New', 'Auction19', 'Auction20', 2.15, '2024-01-15',
    45.00, 22.50, 1, '891122456789', 'A decorrer'),
    ('M', '2023-11-23', 'Valencia', 'Jersey', 'Player-autographed jersey',
    '23', 'Excellent', 'Auction20', 'Auction21', 5.25, '2024-01-15',
    125.00, 62.50, 2, '567890123451', 'A decorrer'),
    ('XL', '2023-11-24', 'Villarreal', 'Football', 'Replica football',
    '24', 'Good', 'Auction21', 'Auction22', 3.50, '2024-01-15',
    95.00, 47.50, 3, '584720193218', 'A decorrer'),
    ('S', '2023-11-25', 'Celta Vigo', 'Shirt', 'Team-logo shirt',
    '25', 'New', 'Auction22', 'Auction23', 2.25, '2024-01-15',
    70.00, 35.00, 3, '891122456789', 'A decorrer'),
    ('L', '2023-11-26', 'Espanyol', 'Cap', 'Autographed team cap',
    '26', 'Excellent', 'Auction23', 'Auction24', 2.10, '2024-01-15',
    50.00, 25.00, 4, '584720193218', 'A decorrer');






-- Insert additional data into Licitacao table
INSERT INTO Licitacao (ValorLicitacao, NIBComprador, IdLeilao)
VALUES 
    (70.00, 584720193218, 1),
    (45.00, 891122456789, 2),
    (25.00, 987654321098, 3),
    (100.00, 987654321098, 3),
    (65.00, 584720193218, 5),
    (40.00, 987654321098, 6);
  
