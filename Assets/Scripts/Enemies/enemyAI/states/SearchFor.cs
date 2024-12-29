using UnityEngine;
using UnityEngine.AI;
using State = BaseStateMachines.State;

namespace Enemies.enemyAI.states
{
    // 2 coisas:  talvez dividir responsabilidades com o onvision range que quer fazer a mesma busca que essa classe
    // e talvez criar uma classe/interface que melhora a comunicacao entre enemybehaviour e os estados
    public class SearchFor : State
    {
        private LayerMask searchLayer;
        private GameObject ownerGameObject;
        private float searchRadius;
        private string tagToSearchFor;
        private NavMeshAgent navMeshAgent;
        
        public SearchFor(LayerMask searchLayer, GameObject owner, float searchRadius, string tagToSearchFor,
                            NavMeshAgent navMeshAgent)
        {
            this.searchLayer = searchLayer;
            this.ownerGameObject = owner;
            this.searchRadius = searchRadius;
            this.tagToSearchFor = tagToSearchFor;
            this.navMeshAgent = navMeshAgent;

        }
        
        public override void Enter() => gameObject.SetActive(true);

        public override void Exit() => gameObject.SetActive(false);

        public override void Execute()
        {
            var hitObjects = Physics2D.OverlapCircleAll(ownerGameObject.transform.position, searchRadius);
            foreach (var hitObject in hitObjects)
            {
                if (hitObject.gameObject.CompareTag(tagToSearchFor))
                {
                    navMeshAgent.SetDestination(hitObject.transform.position);
                }

                break;
            }
        }   
    }
}
