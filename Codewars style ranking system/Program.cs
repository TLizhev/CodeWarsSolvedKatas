using System;

namespace Codewars_style_ranking_system
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.incProgress(1);
            user.incProgress(1);

            Console.WriteLine(user.progress);
            Console.WriteLine(user.rank);
        }

        public class User
            {
                private int ranks = -8;
                private int prog = 0;

                public int rank
                {
                    get { return ranks; }

                    set
                    {
                        if (this.ranks > 8)
                        {
                            throw new ArgumentException();
                        }

                        this.ranks = value;
                    }
                }

                public int progress
                {
                    get { return prog; }
                    set { this.prog = value; }
                }

                public void incProgress(int rank)
                {
                    if (rank == 0 || rank < -8)
                    {
                        throw new ArgumentException();
                    }

                    int[] differenceArr = {-8, -7, -6, -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6, 7, 8};

                    var difference = 0;

                    for (int i = 1; i < differenceArr.Length; i++)
                    {
                        if (differenceArr[i].Equals(rank))
                        {
                            difference =Math.Abs(this.rank - differenceArr[i])-1;
                        }
                        
                    }


                    int formula = (10 * difference * difference);

                    if (difference > -1)
                    {

                        switch (difference)
                        {
                            case -1:
                                progress += 1;
                                break;

                            case 0:
                                progress += 3;
                                break;

                            default:
                                progress += formula;
                                break;
                        }

                        if (progress > 99)
                        {
                            this.progress = progress % 100;
                            if (this.rank > -1)
                            {
                                this.rank += 1;
                            }

                            this.rank += formula / 100;

                        }

                        if (this.rank > 8)
                        {
                            this.rank = 8;
                            this.progress = 0;
                        }

                    }
                }
            }
        }
    }
