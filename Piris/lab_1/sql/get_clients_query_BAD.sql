select C.*, M.Name as M_Name, Ct.Name as CT_Name, P.*, D.Name as D_Name, Cz.Name as Cz_Name 
                    from Client as C 
                    join Marital_Status as M
                    on C.Marital_Status_Id = M.Id
                    join City as Ct
                    on C.City_Id = Ct.Id
                    join Passport as P
                    on C.Passport_Id = P.Id
                    join Disability as D
                    on C.Disability_Id = D.Id
                    join Citizenship as Cz
                    on C.Citizenship_Id = Cz.Id;
				