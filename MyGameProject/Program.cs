using System;
using MyGameProject.Abstract;
using MyGameProject.Concrete;
using MyGameProject.Entities;

GamerManager gamerManager = new GamerManager(new UserValidationManager());
GameManager gameManager = new GameManager();
CampaignManager campaignManager = new CampaignManager();

Gamer gamer = new Gamer();
gamer.FirstName = "ANIL";
gamer.LastName = "PEKİN";
gamer.Id = 1;
gamer.BirthYear = 1991;
gamer.IdentityNumber = 12345;

Game game = new Game();
game.GameName = "Detroit Become Human";
game.GameCategory = "Single Player";
game.GamePrice = 140;

Campaign campaign = new Campaign();
campaign.CampaignName = "Student Campaign";
campaign.CampaignDiscount = 40;

gamerManager.Add(gamer);
gameManager.Add(game);
campaignManager.Add(campaign);

GameSaleManager gameSaleManager = new GameSaleManager();
gameSaleManager.Sale(gamer, game, campaign);




