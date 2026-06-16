Console.Write("Informe a idade: ");
        int idade = int.Parse(Console.ReadLine());

        string faixa;

        // Classifica a faixa etária
        if (idade >= 0 && idade <= 11)
        {
            faixa = "criança";
        }
        else if (idade >= 12 && idade <= 17)
        {
            faixa = "adolescente";
        }
        else if (idade >= 18 && idade <= 59)
        {
            faixa = "adulto";
        }
        else
        {
            faixa = "idoso";
        }

        // Exibe o resultado
        Console.WriteLine($"Faixa etária: {faixa}.");