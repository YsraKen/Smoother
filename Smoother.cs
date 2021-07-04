using UnityEngine;

public class Smoother{
	float current, velocity, smoothTime;
	
	public Smoother(){}
	public Smoother(float smoothTime){ this.smoothTime = smoothTime; }
	
	public float Dampen(float target){
		current = Mathf.SmoothDamp(current, target, ref velocity, smoothTime);
		return current;
	}
	
	public float Dampen(float target, float modifiedSmoothTime){
		current = Mathf.SmoothDamp(current, target, ref velocity, modifiedSmoothTime);
		return current;
	}
}

public class SmootherAngle{
	float current, velocity, smoothTime;
	
	public SmootherAngle(){}
	public SmootherAngle(float smoothTime){ this.smoothTime = smoothTime; }
	
	public float Dampen(float target){
		current = Mathf.SmoothDampAngle(current, target, ref velocity, smoothTime);
		return current;
	}
	
	public float Dampen(float target, float modifiedSmoothTime){
		current = Mathf.SmoothDampAngle(current, target, ref velocity, modifiedSmoothTime);
		return current;
	}
}

public class Smoother2D{
	Vector2 current, velocity;
	float smoothTime;
	
	public Smoother2D(){}
	public Smoother2D(float smoothTime){ this.smoothTime = smoothTime; }
	
	public Vector2 Dampen(Vector2 target){
		current = Vector2.SmoothDamp(current, target, ref velocity, smoothTime);
		return current;
	}
	
	public Vector2 Dampen(Vector2 target, float modifiedSmoothTime){
		current = Vector2.SmoothDamp(current, target, ref velocity, modifiedSmoothTime);
		return current;
	}
}

public class Smoother3D{
	Vector3 current, velocity;
	float smoothTime;
	
	public Smoother3D(){}
	public Smoother3D(float smoothTime){ this.smoothTime = smoothTime; }
	
	public Vector3 Dampen(Vector3 target){
		current = Vector3.SmoothDamp(current, target, ref velocity, smoothTime);
		return current;
	}
	
	public Vector3 Dampen(Vector3 target, float modifiedSmoothTime){
		current = Vector3.SmoothDamp(current, target, ref velocity, modifiedSmoothTime);
		return current;
	}
}