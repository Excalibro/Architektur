/*Create Vertical Loops*/

for (unsigned int u = 0; u<GAM_Prisms; u++)
{
	for (unsigned int v = 0; v<GAM_Prisms; v++)
	{
	 if (u != v)
	 {
		
            int Pointer_U = 0;
            int Pointer_V = 0;

            bool VerticalLoopsFinished = false;

        while(Pointer_V < GAM_Prisms[V].GAM_Loops.size() && Pointer_U < GAM_Prisms[u].GAM_Loops.size())
            {

            if (GAM_Prisms[u].GAM_Loops[LoopId].Z < GAM_Prisms[v].GAM_Loops[Pointer].Z)
                {
                    Pointer_U ++;
                }
            else if (GAM_Prisms[u].GAM_Loops[LoopId].Z == GAM_Prisms[v].GAM_Loops[Pointer].Z)
                {
                    // Add Intersection Vertices on GAM_Prisms[u].GAM_Loops[LoopId] and GAM_Prisms[v].GAM_Loops[Pointer]
                    // Increment LoopId
                }
            else if ( Pointer != GAM_Prisms[v].GAM_Loops.size() -1)
                {
                    if (GAM_Prisms[u].GAM_Loops[LoopId].Z > GAM_Prisms[v].GAM_Loops[Pointer].Z &&
                        GAM_Prisms[u].GAM_Loops[LoopId].Z > GAM_Prisms[v].GAM_Loops[Pointer+1].Z )
                       {
                           // Insert Loop
                       }
                }
             else ()
              {
                Pointer_V ++
              }
        
            }

	 }
	}
}


/* Gam setup bounds*/
 
float x_Max;
float x_Min;
float y_Max;
float y_Min;
for (unsigned int i = 1; i < GAM_Vertices.size(); i++)
    {
    if (i)


    }