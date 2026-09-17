/*
Orbital - Crew Investigative : Download information off of players by staying in their orbit (hence orbital)

Passive: The Orbital can see where they ended previous rounds on their meeting map
Download 1: View target's location for that round on the meeting map, including if they died that round
            If the target dies after having Download 1 Completed on them, their body will show on the map.
            If their body is removed, they will not show on the map.
            If their body moves (via Undertaker,Transporter, etc), their current location will be shown, not location of death.
Download 2: Maybe requires something else (tasks, other players download) to start? 
            View the target's entire location history
            Functions similar to the Orbital's Passive
Download 3: Show all players within orbit(?) at for all instances of the target.
            This is very strong, maybe within orbit is too much
Downside: If not within a radius of a player, the Orbital will "drift", not being able to control their movement. 
          Drifting for long enough can cause death (toggle). 
          Because of this, Orbital is very vulnerable to the Controlled, Teleported, and Impaired effects, + Sabotages
          Drifting while mid-download will lose some, but not all progress.

Playstyle: The Orbital is forced to buddy up and cannot go alone, leaving it vulernable to getting killed when
           one on one. Motivation to not focus down a single player immediately (d3) is needed to prevent hard pairs. 
           Requirements for other downloads or tasks to be completed to advance to the next stage should be baked into
           Orbital's Kit. 
           Also, the prospect of the Orbital naturally dying adds a nice possible death cause. 
           Orbital will usually be quieter during meetings (studying the map)
           

Technical Problems: All round end location data needs to be kept and tracked, not just Orbital's.
                    Circles: Every Player has an orbit, needing a lot of circle math to be completed for drift calculations.
                    A lot of buttons: Download Times should all be induvidually adjustable, alongside orbit size,
                    drift "stamina" and regen, and cutoff penalty
*/                    
