using System;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int numRaccoonsPlaying = 3;
            int numRaccoonsLeaving = 2;
            int numRaccoonsLeft = numRaccoonsPlaying - numRaccoonsLeaving;

            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int numFlowers = 5;
            int numBees = 3;
            int numBeesLessThanFlowers = numFlowers - numBees;

            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int origPigeon = 1;
            int newPigeon = 1;
            int totalPigeons = origPigeon + newPigeon;

            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int numOwlsSitting = 3;
            int numNewOwls = 2;
            int numTotalOwlsOnFence = numOwlsSitting + numNewOwls;

            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int numBeaversWorking = 2;
            int numBeaversLeaving = 1;
            int numBeaversLeft = numBeaversWorking - numBeaversLeaving;

            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int numToucansSitting = 2;
            int numToucansJoining = 1;
            int numTotalToucans = numToucansSitting + numToucansJoining;

            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int numSquirrelsInTree = 4;
            int numNutsInTree = 2;
            int numSquirrelsMoreThanNuts = numSquirrelsInTree - numNutsInTree;

            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            const double quarterValue = 0.25;
            const double dimeValue = 0.10;
            const double nickleValue = 0.05;
            int numOfQuarters = 1;
            int numOfDimes = 1;
            int numOfNickels = 2;

            double totalMoney = (numOfQuarters * quarterValue) + (numOfDimes * dimeValue) + (numOfNickels * nickleValue);

            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int numOfBrierHiltMuffins = 18;
            int numOfMacAdamsMuffins = 20;
            int numOfFlanneryMuffins = 17;
            int totalMuffins = numOfBrierHiltMuffins + numOfMacAdamsMuffins + numOfFlanneryMuffins;

            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            double costOfYoyo = 0.24;
            double costOfWhitle = 0.14;
            double totalPrice = costOfYoyo + costOfWhitle;
            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */
            int numOfLargeMarshmallows = 8;
            int numOfMiniMarshmallows = 10;
            int totalMarshmallowsUsed = numOfLargeMarshmallows + numOfMiniMarshmallows;

            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int inchesOfSnowAtHilts = 29;
            int inchesOfSnowAtSchool = 17;
            int differenceOfSnowInInches = inchesOfSnowAtHilts - inchesOfSnowAtSchool;
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            double startingMoney = 10.00;
            double costOfToyTruck = 3.00;
            double costOfPencilCase = 2.00;
            double totalCost = costOfToyTruck + costOfPencilCase;
            double remainingMoney = startingMoney - totalCost;
            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int startingMarbles = 16;
            int lostMarbles = 7;
            int remainingMarbles = startingMarbles - lostMarbles;
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int startingSeaShells = 19;
            int desiredSeaShells = 25;
            int remainingSeaShells = desiredSeaShells - startingSeaShells;
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int totalBalloons = 17;
            int redBalloons = 8;
            int greenBalloons = totalBalloons - redBalloons;
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int startingBooksOnShelf = 38;
            int addedBooksToShelf = 10;
            int resultingBooksOnShelf = startingBooksOnShelf + addedBooksToShelf;
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int numLegs = 6;
            int numBeesForLegCount = 8;
            int totalLegs = numLegs * numBeesForLegCount;
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            double costOfIceCreamCone = .99;
            int numIceCreamCones = 2;
            double totalCostOfIceCream = (double)numIceCreamCones * costOfIceCreamCone;
            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int numRocksNeeded = 125;
            int numRocksOwned = 64;
            int numRocksLeft = numRocksNeeded - numRocksOwned;

            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int numMarbles = 38;
            int numMarblesLost = 15;
            int numMarblesLeft = numMarbles - numMarblesLost;
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int milesToConcert = 78;
            int milesTraveled = 32;
            int milesLeft = milesToConcert - milesTraveled;
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */            
            int minsSpentShovelingMorning = 90;
            int minsSpentShovelingAfternoon = 45;
            int minsSpentShovelingTotal = minsSpentShovelingMorning + minsSpentShovelingAfternoon;
            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            double costOfHotDog = 0.50;
            int numOfHotDogsPurchased = 6;
            double moneySpentOnHotDogs = (double)numOfHotDogsPurchased * costOfHotDog;
            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            int centsHiltHas = 50;
            int costOfPencilInCents = 7;
            int maxPencilsHiltCanBuy = centsHiltHas / costOfPencilInCents;
            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int butterfliesSeen = 33;
            int orangeButterflies = 20;
            int redButterflies = butterfliesSeen - orangeButterflies;
            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            double amountPaid = 1.00;
            double amountOwed = 0.54;
            double change = amountPaid - amountOwed;
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int numTrees = 13;
            int numNewTrees = 12;
            int newTreeTotal = numTrees + numNewTrees;
            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int daysUntilGrandma = 2;
            int hoursInADay = 24;
            int hoursUntilGrandma = daysUntilGrandma * hoursInADay;
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int numCousins = 4;
            int piecesOfGum = 5;
            int totalGumNeeded = numCousins * piecesOfGum;
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            double dansMoney = 3.00;
            double costOfCandyBar = 1.00;
            dansMoney -= costOfCandyBar;
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int numBoats = 5;
            int numPeopleInBoats = 3;
            int totalPeople = numBoats * numPeopleInBoats;
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int numLegoPieces = 380;
            int numLegoPiecesLost = 57;
            int numRemainingLegoPieces = numLegoPieces - numLegoPiecesLost;
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int numMuffinsToBake = 83;
            int numMuffinsBaked = 35;
            int numMuffinsLeft = numMuffinsToBake - numMuffinsBaked;
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willysCrayons = 1400;
            int lucysCrayons = 290;
            int differenceOfCrayons = willysCrayons - lucysCrayons;
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int stickersPerPage = 10;
            int numOfPages = 22;
            int totalStickers = numOfPages * stickersPerPage;
            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int totalCupcakes = 96;
            int numOfChildren = 8;
            int cupscakesPerChild = totalCupcakes / numOfChildren;
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            int numGingerbreadCookies = 47;
            int cookiesPerJar = 6;
            int cookiesNotInJars = numGingerbreadCookies % cookiesPerJar;
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int numCroissants = 59;
            int numNeighbors = 8;
            int croissantsLeft = numCroissants % numNeighbors;
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int totalCookies = 276;
            int cookiesPerTray = 12;
            int traysNeeded = totalCookies / cookiesPerTray;
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int totalPretzels = 480;
            int pretzelsPerServing = 12;
            int numOfServings = totalPretzels / pretzelsPerServing;
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int lemonCupcakesCooked = 53;
            int lemonCupcakesRemaining = 2;
            int lemonCupcakesPerBox = 3;
            int numOfBoxes = (lemonCupcakesCooked - lemonCupcakesRemaining) / lemonCupcakesPerBox;
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int numCarrotSticks = 74;
            int numPeopleToServe = 12;
            int leftOverCarrotSticks = numCarrotSticks % numPeopleToServe;
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int numTeddyBears = 98;
            int teddyBearsPerShelf = 7;
            int shelvesFilled = numTeddyBears / teddyBearsPerShelf;
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int picturesPerAlbum = 20;
            int totalPictures = 480;
            int albumsNeeded = totalPictures / picturesPerAlbum;
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int totalTradingCards = 94;
            int cardsPerBox = 8;
            int numBoxes = totalTradingCards / cardsPerBox;
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int totalBooks = 210;
            int numShelves = 10;
            int booksPerShelf = totalBooks / numShelves;
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            int numOfCroissants = 17;
            int numOfGuests = 7;
            int croissantsPerGuest = numOfCroissants / numOfGuests;
            /*
                CHALLENGE PROBLEMS
            */

            /*
            Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painter working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in 
            feet by the combined hourly rate of the painters.
            Challenge: How many days will it take the pair to paint 623 rooms assuming they work 8 hours a day?.
            */
            int feetInARoom = 12 * 2 + 14 * 2;
            double billsTimeToPaintRoom = 2.15;
            double billPaintsPerHour = 1 / billsTimeToPaintRoom;
            double jillsTimeToPaintRoom = 1.9;
            double jillPaintsPerHour = 1 / jillsTimeToPaintRoom;
            double combinedPaintRate = billPaintsPerHour + jillPaintsPerHour;
            double feetPaintedPerHour = combinedPaintRate * feetInARoom;
            int roomsToPaint = 5;
            int feetToPaint = roomsToPaint * feetInARoom;
            double hoursToWork = (double)feetToPaint / (double)feetPaintedPerHour;
            int roomsToPaintChallenge = 623;
            int feetToPaintChallenge = roomsToPaintChallenge * feetInARoom;
            int hoursWorkedPerDay = 8;
            double hoursToWorkChallenge = (double)feetToPaintChallenge / (double)feetPaintedPerHour;
            int daysToWork = (int) Math.Ceiling( hoursToWorkChallenge / hoursWorkedPerDay);

            //Console.WriteLine("feetInARoom: " + feetInARoom);
            //Console.WriteLine("billPaintsPerHour: " + billPaintsPerHour);
            //Console.WriteLine("jillPaintsPerHour: " + jillPaintsPerHour);
            //Console.WriteLine("combinedPaintRate: " + combinedPaintRate);
            //Console.WriteLine("feetPaintedPerHour: " + feetPaintedPerHour);
            //Console.WriteLine("feetToPaint: " + feetToPaint);
            //Console.WriteLine("hoursToWork: " + hoursToWork);
            //Console.WriteLine("daysToWork: " + daysToWork);

            /*
            Create and assign variables to hold your first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold your full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period.
            Example: "Hopper, Grace B."
            */
            string firstName = "Jack";
            string lastName = "Egan";
            string middleInitial = "M";
            string fullName = lastName + ", " + firstName + " " + middleInitial + ".";
            /*
            The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip has been completed?
            Hint: The percent completed is the miles already travelled divided by the total miles.
            Challenge: Display as an integer value between 0 and 100 using casts.
            */
            int totalDistance = 800;
            int distanceTraveled = 537;
            double percentTraveled = (double) distanceTraveled / totalDistance;
            int percentTraveledAsInt = (int)(percentTraveled * 100);
            Console.WriteLine(percentTraveledAsInt + "%");
        }
    }
}
