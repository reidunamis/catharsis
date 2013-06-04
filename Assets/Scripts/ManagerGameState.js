#pragma strict
enum GameState
{
	Start,
	Game,
	Pause,
	End,
	Switch
}
private var state : GameState = GameState.Start;

function Update () {
	switch(state)
	{
		case GameState.Start:
		break;
		
		case GameState.Game:
		break;
		
		case GameState.Pause:
		break;
		
		case GameState.End:
		break;
		
		case GameState.Switch:
		break;
	}
}

function StateChange (newState : GameState) {
	state = newState;
	
	switch(state)
	{
		case GameState.Start:
		break;
		
		case GameState.Game:
		break;
		
		case GameState.Pause:
		break;
		
		case GameState.End:
		break;
		
		case GameState.Switch:
		break;
	}
}